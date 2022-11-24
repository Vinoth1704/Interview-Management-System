using IMS.Models;
using IMS.DataAccessLayer;
using IMS.Validations;
using IMS.DataFactory;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Diagnostics;

namespace IMS.Service
{
    public class TokenService : ITokenService
    {
        private IEmployeeDataAccessLayer _employeeDataAccessLayer;
        private ILogger<TokenService> _logger;
        private IConfiguration _configuration;
        
        private readonly Stopwatch _stopwatch = new Stopwatch();
        
        private bool IsTracingEnabled;
        public TokenService(ILogger<TokenService> logger, IConfiguration configuration, IEmployeeDataAccessLayer employeeDataAccessLayer)
        {
            _logger = logger;
            _configuration = configuration;
            _employeeDataAccessLayer = employeeDataAccessLayer;// DataFactory.EmployeeDataFactory.GetEmployeeDataAccessLayerObject(logger);
            IsTracingEnabled = _employeeDataAccessLayer.GetIsTraceEnabledFromConfiguration();
        }

        public object AuthToken(string employeeMail, string password)
        {
            _stopwatch.Start();
            try
            {
                var user = _employeeDataAccessLayer.CheckLoginCrendentials(employeeMail, password);

                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Email",user.EmailId!),
                        new Claim("UserId", user.EmployeeId.ToString()),
                        new Claim("DepartmentId",user.DepartmentId.ToString()),
                        new Claim("UserName", user.Name!.ToString()),
                        new Claim(ClaimTypes.Role,user.RoleId.ToString()),
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var encryptingCredentials = new EncryptingCredentials(key, JwtConstants.DirectKeyUseAlg, SecurityAlgorithms.Aes256CbcHmacSha512);
                var token = new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    new ClaimsIdentity(claims),
                    null,
                    expires: DateTime.UtcNow.AddHours(6),
                    null,
                    signingCredentials: signIn,
                    encryptingCredentials: encryptingCredentials
                    );


                var Result = new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    ExpiryInMinutes = 360,
                    UserHash=getUserHash(user.Role),
                    // IsAdmin = user.RoleId == 10 ? true : false,
                    // IsTAC = user.RoleId == 9 ? true : false,
                    // IsManagement=user.Role!.IsManagement? true : false,
                    UserName=user.Name
                };

                return Result;

            }
            catch (ValidationException loginCredentialsNotValid)
            {
                _logger.LogError($"Employee DAL : CheckLoginCredentails throwed an exception : {loginCredentialsNotValid.Message}");
                throw loginCredentialsNotValid;
            }
            catch (Exception exception)
            {
                _logger.LogError($"Employee DAL : CheckLoginCredentails throwed an exception : {exception.Message}");
                throw ;
            }
            finally
            {
                _stopwatch.Stop();
                _logger.LogInformation($"token Service Time elapsed for  AuthToken(string employeeMail, string password) :{_stopwatch.ElapsedMilliseconds}ms");
            }
        }

        private string getUserHash(Role role)
        {
            if(role.RoleName.ToLower()=="tac")
                return UtilityService.TacHashKey;
            if(role.RoleName.ToLower()=="admin")
                return UtilityService.AdminHashKey;
            if(role.IsManagement)
                return UtilityService.ManagementHashKey;
            
            return UtilityService.InterviewerHashKey;
        }
    }
}