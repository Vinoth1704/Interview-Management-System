﻿// <auto-generated />
using System;
using IMS.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Source.Migrations
{
    [DbContext(typeof(InterviewManagementSystemDbContext))]
    [Migration("20220517122330_Updated")]
    partial class Updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IMS.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = ".NET",
                            IsActive = true
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "JAVA",
                            IsActive = true
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "ORACLE",
                            IsActive = true
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Not Applicable",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("IMS.Models.Drive", b =>
                {
                    b.Property<int>("DriveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriveId"), 1L, 1);

                    b.Property<int?>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CancelReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsScheduled")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("ModeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.Property<double>("SlotTiming")
                        .HasColumnType("float");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DriveId");

                    b.HasIndex("AddedBy");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PoolId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Drives");
                });

            modelBuilder.Entity("IMS.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeAceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdminAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdminResponded")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DepartmentId = 1,
                            EmailId = "prithvi@gmail.com",
                            EmployeeAceNumber = "ACE0001",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Prithvi",
                            Password = "Pass@12345",
                            ProjectId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            DepartmentId = 1,
                            EmailId = "vinoth@gmail.com",
                            EmployeeAceNumber = "ACE0002",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Vinoth",
                            Password = "Pass@12345",
                            ProjectId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            DepartmentId = 1,
                            EmailId = "Sheik@gmail.com",
                            EmployeeAceNumber = "ACE0003",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Sheik",
                            Password = "Pass@12345",
                            ProjectId = 1,
                            RoleId = 3
                        },
                        new
                        {
                            EmployeeId = 4,
                            DepartmentId = 2,
                            EmailId = "darshana@gmail.com",
                            EmployeeAceNumber = "ACE0004",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Darshana",
                            Password = "Pass@12345",
                            ProjectId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeId = 5,
                            DepartmentId = 2,
                            EmailId = "aravind@gmail.com",
                            EmployeeAceNumber = "ACE0005",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Aravind",
                            Password = "Pass@12345",
                            ProjectId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            EmployeeId = 6,
                            DepartmentId = 2,
                            EmailId = "kumaresh@gmail.com",
                            EmployeeAceNumber = "ACE0006",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Kumaresh",
                            Password = "Pass@12345",
                            ProjectId = 2,
                            RoleId = 3
                        },
                        new
                        {
                            EmployeeId = 7,
                            DepartmentId = 3,
                            EmailId = "gokul@gmail.com",
                            EmployeeAceNumber = "ACE0007",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Gokul",
                            Password = "Pass@12345",
                            ProjectId = 3,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeId = 8,
                            DepartmentId = 3,
                            EmailId = "deepika@gmail.com",
                            EmployeeAceNumber = "ACE0008",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Deepika",
                            Password = "Pass@12345",
                            ProjectId = 3,
                            RoleId = 2
                        },
                        new
                        {
                            EmployeeId = 9,
                            DepartmentId = 3,
                            EmailId = "remuki@gmail.com",
                            EmployeeAceNumber = "ACE0009",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Remuki",
                            Password = "Pass@12345",
                            ProjectId = 3,
                            RoleId = 3
                        },
                        new
                        {
                            EmployeeId = 10,
                            DepartmentId = 4,
                            EmailId = "vishnu@gmail.com",
                            EmployeeAceNumber = "ACE0010",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Vishnu",
                            Password = "Pass@12345",
                            ProjectId = 4,
                            RoleId = 9
                        },
                        new
                        {
                            EmployeeId = 11,
                            DepartmentId = 4,
                            EmailId = "sandhiya@gmail.com",
                            EmployeeAceNumber = "ACE0011",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Sandhiya",
                            Password = "Pass@12345",
                            ProjectId = 4,
                            RoleId = 9
                        },
                        new
                        {
                            EmployeeId = 12,
                            DepartmentId = 4,
                            EmailId = "mani@gmail.com",
                            EmployeeAceNumber = "ACE0012",
                            IsActive = true,
                            IsAdminAccepted = false,
                            IsAdminResponded = false,
                            Name = "Mani",
                            Password = "Pass@12345",
                            ProjectId = 4,
                            RoleId = 10
                        });
                });

            modelBuilder.Entity("IMS.Models.EmployeeAvailability", b =>
                {
                    b.Property<int>("EmployeeAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeAvailabilityId"), 1L, 1);

                    b.Property<string>("CancellationReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriveId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InterviewDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInterviewCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInterviewScheduled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeAvailabilityId");

                    b.HasIndex("DriveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAvailability");
                });

            modelBuilder.Entity("IMS.Models.EmployeeDriveResponse", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResponseId"), 1L, 1);

                    b.Property<int>("DriveId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ResponseType")
                        .HasColumnType("int");

                    b.HasKey("ResponseId");

                    b.HasIndex("DriveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeDriveResponse");
                });

            modelBuilder.Entity("IMS.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            IsActive = true,
                            LocationName = "Chennai"
                        },
                        new
                        {
                            LocationId = 2,
                            IsActive = true,
                            LocationName = "Bangalore"
                        },
                        new
                        {
                            LocationId = 3,
                            IsActive = true,
                            LocationName = "Mumbai"
                        },
                        new
                        {
                            LocationId = 4,
                            IsActive = true,
                            LocationName = "Delhi"
                        },
                        new
                        {
                            LocationId = 5,
                            IsActive = true,
                            LocationName = "Noida"
                        });
                });

            modelBuilder.Entity("IMS.Models.Pool", b =>
                {
                    b.Property<int>("PoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoolId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PoolName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("PoolId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Pools");

                    b.HasData(
                        new
                        {
                            PoolId = 1,
                            DepartmentId = 1,
                            IsActive = true,
                            PoolName = "Fresher .NET"
                        },
                        new
                        {
                            PoolId = 2,
                            DepartmentId = 1,
                            IsActive = true,
                            PoolName = "SSE .NET"
                        },
                        new
                        {
                            PoolId = 3,
                            DepartmentId = 2,
                            IsActive = true,
                            PoolName = "Fresher JAVA"
                        },
                        new
                        {
                            PoolId = 4,
                            DepartmentId = 2,
                            IsActive = true,
                            PoolName = "SSE JAVA"
                        },
                        new
                        {
                            PoolId = 5,
                            DepartmentId = 3,
                            IsActive = true,
                            PoolName = "Fresher ORACLE"
                        },
                        new
                        {
                            PoolId = 6,
                            DepartmentId = 3,
                            IsActive = true,
                            PoolName = "SSE ORACLE"
                        });
                });

            modelBuilder.Entity("IMS.Models.PoolMembers", b =>
                {
                    b.Property<int>("PoolMembersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoolMembersId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PoolId")
                        .HasColumnType("int");

                    b.HasKey("PoolMembersId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PoolId");

                    b.ToTable("PoolMembers");

                    b.HasData(
                        new
                        {
                            PoolMembersId = 1,
                            EmployeeId = 1,
                            IsActive = true,
                            PoolId = 1
                        },
                        new
                        {
                            PoolMembersId = 2,
                            EmployeeId = 2,
                            IsActive = true,
                            PoolId = 1
                        },
                        new
                        {
                            PoolMembersId = 3,
                            EmployeeId = 2,
                            IsActive = true,
                            PoolId = 2
                        },
                        new
                        {
                            PoolMembersId = 4,
                            EmployeeId = 3,
                            IsActive = true,
                            PoolId = 2
                        },
                        new
                        {
                            PoolMembersId = 5,
                            EmployeeId = 4,
                            IsActive = true,
                            PoolId = 3
                        },
                        new
                        {
                            PoolMembersId = 6,
                            EmployeeId = 5,
                            IsActive = true,
                            PoolId = 3
                        },
                        new
                        {
                            PoolMembersId = 7,
                            EmployeeId = 5,
                            IsActive = true,
                            PoolId = 4
                        },
                        new
                        {
                            PoolMembersId = 8,
                            EmployeeId = 6,
                            IsActive = true,
                            PoolId = 4
                        },
                        new
                        {
                            PoolMembersId = 9,
                            EmployeeId = 7,
                            IsActive = true,
                            PoolId = 5
                        },
                        new
                        {
                            PoolMembersId = 10,
                            EmployeeId = 8,
                            IsActive = true,
                            PoolId = 5
                        },
                        new
                        {
                            PoolMembersId = 11,
                            EmployeeId = 8,
                            IsActive = true,
                            PoolId = 6
                        },
                        new
                        {
                            PoolMembersId = 12,
                            EmployeeId = 9,
                            IsActive = true,
                            PoolId = 6
                        });
                });

            modelBuilder.Entity("IMS.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            DepartmentId = 1,
                            IsActive = true,
                            ProjectName = "IMS_NET"
                        },
                        new
                        {
                            ProjectId = 2,
                            DepartmentId = 2,
                            IsActive = true,
                            ProjectName = "IMS_JAVA"
                        },
                        new
                        {
                            ProjectId = 3,
                            DepartmentId = 3,
                            IsActive = true,
                            ProjectName = "IMS_ORACLE"
                        },
                        new
                        {
                            ProjectId = 4,
                            DepartmentId = 4,
                            IsActive = true,
                            ProjectName = "Not Applicable"
                        });
                });

            modelBuilder.Entity("IMS.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            IsActive = true,
                            RoleName = "Software Developer"
                        },
                        new
                        {
                            RoleId = 2,
                            IsActive = true,
                            RoleName = "Senior Software Developer"
                        },
                        new
                        {
                            RoleId = 3,
                            IsActive = true,
                            RoleName = "Project Manager"
                        },
                        new
                        {
                            RoleId = 4,
                            IsActive = true,
                            RoleName = "Module Lead"
                        },
                        new
                        {
                            RoleId = 5,
                            IsActive = true,
                            RoleName = "Technical Lead"
                        },
                        new
                        {
                            RoleId = 6,
                            IsActive = true,
                            RoleName = "Software Architect"
                        },
                        new
                        {
                            RoleId = 7,
                            IsActive = true,
                            RoleName = "Delivery Manager"
                        },
                        new
                        {
                            RoleId = 8,
                            IsActive = true,
                            RoleName = "Service Line Owner"
                        },
                        new
                        {
                            RoleId = 9,
                            IsActive = true,
                            RoleName = "Talent"
                        },
                        new
                        {
                            RoleId = 10,
                            IsActive = true,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("IMS.Models.Drive", b =>
                {
                    b.HasOne("IMS.Models.Employee", "AddedEmployee")
                        .WithMany("AddedEmployeeDrives")
                        .HasForeignKey("AddedBy");

                    b.HasOne("IMS.Models.Department", "Department")
                        .WithMany("DrivesUnderDepartment")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Location", "Location")
                        .WithMany("DrivesUnderLocation")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Pool", "Pool")
                        .WithMany("DrivesUnderPool")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Employee", "UpdatedEmployee")
                        .WithMany("UpdatedEmployeeDrives")
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("AddedEmployee");

                    b.Navigation("Department");

                    b.Navigation("Location");

                    b.Navigation("Pool");

                    b.Navigation("UpdatedEmployee");
                });

            modelBuilder.Entity("IMS.Models.Employee", b =>
                {
                    b.HasOne("IMS.Models.Department", "Department")
                        .WithMany("EmployeesUnderDepartment")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Project", "Project")
                        .WithMany("EmployeesUnderProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Role", "Role")
                        .WithMany("EmployeesUnderRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Project");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IMS.Models.EmployeeAvailability", b =>
                {
                    b.HasOne("IMS.Models.Drive", "Drive")
                        .WithMany("DriveSoltResponse")
                        .HasForeignKey("DriveId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Employee", "Employee")
                        .WithMany("EmployeeSlotResponses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Drive");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IMS.Models.EmployeeDriveResponse", b =>
                {
                    b.HasOne("IMS.Models.Drive", "Drive")
                        .WithMany("DriveResponses")
                        .HasForeignKey("DriveId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Employee", "Employee")
                        .WithMany("EmployeeDriveResponses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Drive");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IMS.Models.Pool", b =>
                {
                    b.HasOne("IMS.Models.Department", "department")
                        .WithMany("Pools")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("IMS.Models.PoolMembers", b =>
                {
                    b.HasOne("IMS.Models.Employee", "Employees")
                        .WithMany("PoolMembers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Pool", "Pools")
                        .WithMany("PoolMembers")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Pools");
                });

            modelBuilder.Entity("IMS.Models.Project", b =>
                {
                    b.HasOne("IMS.Models.Department", "department")
                        .WithMany("Projects")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("IMS.Models.Department", b =>
                {
                    b.Navigation("DrivesUnderDepartment");

                    b.Navigation("EmployeesUnderDepartment");

                    b.Navigation("Pools");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("IMS.Models.Drive", b =>
                {
                    b.Navigation("DriveResponses");

                    b.Navigation("DriveSoltResponse");
                });

            modelBuilder.Entity("IMS.Models.Employee", b =>
                {
                    b.Navigation("AddedEmployeeDrives");

                    b.Navigation("EmployeeDriveResponses");

                    b.Navigation("EmployeeSlotResponses");

                    b.Navigation("PoolMembers");

                    b.Navigation("UpdatedEmployeeDrives");
                });

            modelBuilder.Entity("IMS.Models.Location", b =>
                {
                    b.Navigation("DrivesUnderLocation");
                });

            modelBuilder.Entity("IMS.Models.Pool", b =>
                {
                    b.Navigation("DrivesUnderPool");

                    b.Navigation("PoolMembers");
                });

            modelBuilder.Entity("IMS.Models.Project", b =>
                {
                    b.Navigation("EmployeesUnderProject");
                });

            modelBuilder.Entity("IMS.Models.Role", b =>
                {
                    b.Navigation("EmployeesUnderRole");
                });
#pragma warning restore 612, 618
        }
    }
}
