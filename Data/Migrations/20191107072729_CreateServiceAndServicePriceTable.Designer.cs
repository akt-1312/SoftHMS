﻿// <auto-generated />
using System;
using HospitalMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalMS.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191107072729_CreateServiceAndServicePriceTable")]
    partial class CreateServiceAndServicePriceTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalMS.Models.Blood", b =>
                {
                    b.Property<int>("BloodID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .IsRequired();

                    b.HasKey("BloodID");

                    b.ToTable("Bloods");
                });

            modelBuilder.Entity("HospitalMS.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired();

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HospitalMS.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HospitalMS.Models.Designation", b =>
                {
                    b.Property<int>("DesignationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationName")
                        .IsRequired();

                    b.HasKey("DesignationID");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("HospitalMS.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("BloodID");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Degree");

                    b.Property<string>("DescriptionforLeave");

                    b.Property<int>("DesignationID");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("GenCode");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<DateTime?>("JobEnd");

                    b.Property<DateTime?>("JobStart");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber1")
                        .IsRequired();

                    b.Property<string>("PhoneNumber2");

                    b.Property<int>("StatusID");

                    b.Property<string>("UnitName");

                    b.HasKey("DoctorID");

                    b.HasIndex("BloodID");

                    b.HasIndex("DesignationID");

                    b.HasIndex("StatusID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalMS.Models.DoctorDeptUnit", b =>
                {
                    b.Property<int>("DoctorDeptUnitID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<int>("DoctorID");

                    b.Property<int>("UnitID");

                    b.HasKey("DoctorDeptUnitID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("UnitID");

                    b.ToTable("DoctorDeptUnits");
                });

            modelBuilder.Entity("HospitalMS.Models.DoctorSchedule", b =>
                {
                    b.Property<int>("DoctorScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<string>("DepartmentName");

                    b.Property<int>("DoctorID");

                    b.Property<string>("DoctorName");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("PerPatientTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("UnitID");

                    b.Property<string>("UnitName");

                    b.Property<string>("WeekDay");

                    b.HasKey("DoctorScheduleId");

                    b.ToTable("DoctorSchedules");
                });

            modelBuilder.Entity("HospitalMS.Models.DoctorUnit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID");

                    b.Property<int>("UnitID");

                    b.HasKey("ID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("UnitID");

                    b.ToTable("DoctorUnits");
                });

            modelBuilder.Entity("HospitalMS.Models.Gender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired();

                    b.HasKey("GenderID");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("HospitalMS.Models.HospitalInfo", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HospitalAddress")
                        .IsRequired();

                    b.Property<string>("HospitalCode")
                        .IsRequired();

                    b.Property<string>("HospitalEmail");

                    b.Property<string>("HospitalImage");

                    b.Property<string>("HospitalName")
                        .IsRequired();

                    b.Property<string>("HospitalPhoneNo1");

                    b.Property<string>("HospitalPhoneNo2");

                    b.Property<string>("HospitalPhoneNo3");

                    b.Property<string>("HospitalPhoneNo4");

                    b.Property<string>("HospitalWebsite");

                    b.HasKey("HospitalId");

                    b.ToTable("HospitalInfos");
                });

            modelBuilder.Entity("HospitalMS.Models.MaritalStatus", b =>
                {
                    b.Property<int>("MaritalStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaritalStatusName")
                        .IsRequired();

                    b.HasKey("MaritalStatusID");

                    b.ToTable("MaritalStatuses");
                });

            modelBuilder.Entity("HospitalMS.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NationalityName")
                        .IsRequired();

                    b.HasKey("NationalityID");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("HospitalMS.Models.PatientType", b =>
                {
                    b.Property<int>("PatientTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientTypeName")
                        .IsRequired();

                    b.HasKey("PatientTypeID");

                    b.ToTable("PatientTypes");
                });

            modelBuilder.Entity("HospitalMS.Models.Prefix", b =>
                {
                    b.Property<int>("PrefixID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrefixName")
                        .IsRequired();

                    b.HasKey("PrefixID");

                    b.ToTable("Prefixes");
                });

            modelBuilder.Entity("HospitalMS.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceName")
                        .IsRequired();

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HospitalMS.Models.ServicePrice", b =>
                {
                    b.Property<int>("ServicePriceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ForeignerFixedPrice");

                    b.Property<double>("ForeignerFormulaPrice");

                    b.Property<double>("LocalPrice");

                    b.Property<int>("ServiceID");

                    b.HasKey("ServicePriceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ServicePrices");
                });

            modelBuilder.Entity("HospitalMS.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("StateName")
                        .IsRequired();

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("HospitalMS.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired();

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("HospitalMS.Models.Test", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("CustomerId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("HospitalMS.Models.Township", b =>
                {
                    b.Property<int>("TownshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StateId");

                    b.Property<string>("TownshipName")
                        .IsRequired();

                    b.HasKey("TownshipId");

                    b.HasIndex("StateId");

                    b.ToTable("Townships");
                });

            modelBuilder.Entity("HospitalMS.Models.Unit", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<string>("UnitName")
                        .IsRequired();

                    b.HasKey("UnitID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HospitalMS.Models.Doctor", b =>
                {
                    b.HasOne("HospitalMS.Models.Blood", "Blood")
                        .WithMany()
                        .HasForeignKey("BloodID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalMS.Models.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalMS.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.DoctorDeptUnit", b =>
                {
                    b.HasOne("HospitalMS.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalMS.Models.Doctor", "Doctor")
                        .WithMany("DoctorDeptUnits")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalMS.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.DoctorUnit", b =>
                {
                    b.HasOne("HospitalMS.Models.Doctor", "Doctor")
                        .WithMany("DoctorUnits")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HospitalMS.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.ServicePrice", b =>
                {
                    b.HasOne("HospitalMS.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.State", b =>
                {
                    b.HasOne("HospitalMS.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.Township", b =>
                {
                    b.HasOne("HospitalMS.Models.State", "State")
                        .WithMany("Townships")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalMS.Models.Unit", b =>
                {
                    b.HasOne("HospitalMS.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
