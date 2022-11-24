using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using IMS.Models;

namespace IMS.Validations
{
    public static class RoleValidation
    {
        public static void IsRoleNameValid(string roleName)
        {
            if(roleName==null) throw new ValidationException("Role name cannot be null");
            // if(roleName.Length<2) throw new ValidationException("role name is too short");
            if(!Regex.IsMatch(roleName,@"^(?!.*([ ])\1)(?!.*([A-Za-z])\2{2})\w[a-zA-Z\s]*$")) throw new ValidationException("Role Name must be alphabets and of lenght of 3 to 15.");
        }
        public static void IsRoleValid(Role role)
        {
            if(role==null)
            {
                throw new ValidationException("Role cannot be null");
            }
        }
        public static void IsRoleIdValid(int roleId)
        {
            if (roleId <= 0)
            {
                throw new ValidationException("Role Id cannot be zero or less than zero");
            }
        }
    }
}