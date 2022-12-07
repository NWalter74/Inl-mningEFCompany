﻿// <auto-generated />
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20221207103827_SeedDataAdded")]
    partial class SeedDataAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Departmentname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            CompanyId = 101,
                            Departmentname = "IT_S"
                        },
                        new
                        {
                            Id = 1002,
                            CompanyId = 101,
                            Departmentname = "Ekonomi_S"
                        },
                        new
                        {
                            Id = 1003,
                            CompanyId = 101,
                            Departmentname = "Administration_S"
                        },
                        new
                        {
                            Id = 1004,
                            CompanyId = 101,
                            Departmentname = "Styrelse_S"
                        },
                        new
                        {
                            Id = 1005,
                            CompanyId = 102,
                            Departmentname = "IT_D"
                        },
                        new
                        {
                            Id = 1006,
                            CompanyId = 102,
                            Departmentname = "Ekonomi_D"
                        },
                        new
                        {
                            Id = 1007,
                            CompanyId = 102,
                            Departmentname = "Styrelse_D"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Sallary")
                        .HasColumnType("int");

                    b.Property<bool>("UnionMember")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employers");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            DepartmentId = 1001,
                            Firstname = "Kalle",
                            Lastname = "Anka",
                            Sallary = 50000,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 12,
                            DepartmentId = 1002,
                            Firstname = "Bamse",
                            Lastname = "Björn",
                            Sallary = 46000,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 13,
                            DepartmentId = 1003,
                            Firstname = "Pelle",
                            Lastname = "Svanslös",
                            Sallary = 34000,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 14,
                            DepartmentId = 1001,
                            Firstname = "Kajsa",
                            Lastname = "Kavat",
                            Sallary = 32000,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 15,
                            DepartmentId = 1004,
                            Firstname = "Nils",
                            Lastname = "Pyssling",
                            Sallary = 35000,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 16,
                            DepartmentId = 1005,
                            Firstname = "Mamma",
                            Lastname = "Mu",
                            Sallary = 41000,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 17,
                            DepartmentId = 1006,
                            Firstname = "Great",
                            Lastname = "Gris",
                            Sallary = 40000,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 18,
                            DepartmentId = 1007,
                            Firstname = "Pippi",
                            Lastname = "Långstrump",
                            Sallary = 38000,
                            UnionMember = true
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.EmployersRoll", b =>
                {
                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<int>("RollId")
                        .HasColumnType("int");

                    b.HasKey("EmployerId", "RollId");

                    b.HasIndex("RollId");

                    b.ToTable("EmployersRolls");

                    b.HasData(
                        new
                        {
                            EmployerId = 11,
                            RollId = 1
                        },
                        new
                        {
                            EmployerId = 11,
                            RollId = 5
                        },
                        new
                        {
                            EmployerId = 12,
                            RollId = 3
                        },
                        new
                        {
                            EmployerId = 13,
                            RollId = 5
                        },
                        new
                        {
                            EmployerId = 13,
                            RollId = 7
                        },
                        new
                        {
                            EmployerId = 14,
                            RollId = 2
                        },
                        new
                        {
                            EmployerId = 15,
                            RollId = 4
                        },
                        new
                        {
                            EmployerId = 16,
                            RollId = 1
                        },
                        new
                        {
                            EmployerId = 17,
                            RollId = 6
                        },
                        new
                        {
                            EmployerId = 18,
                            RollId = 4
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.MyCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Companyname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Land")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Organisationno")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Companyname = "MittFöretag_S",
                            Land = "Sverige",
                            Organisationno = "123456-7890"
                        },
                        new
                        {
                            Id = 102,
                            Companyname = "MittFöretag_D",
                            Land = "Danmark",
                            Organisationno = "567890-2345"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Roll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Rollname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Rolls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rollname = "Utvecklare"
                        },
                        new
                        {
                            Id = 2,
                            Rollname = "Databasadministratör"
                        },
                        new
                        {
                            Id = 3,
                            Rollname = "Lönespecialist"
                        },
                        new
                        {
                            Id = 4,
                            Rollname = "VD"
                        },
                        new
                        {
                            Id = 5,
                            Rollname = "Teamchef"
                        },
                        new
                        {
                            Id = 6,
                            Rollname = "Redovisningsekonom"
                        },
                        new
                        {
                            Id = 7,
                            Rollname = "Administratör"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.HasOne("Company.Data.Entities.MyCompany", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Company.Data.Entities.Employer", b =>
                {
                    b.HasOne("Company.Data.Entities.Department", "Departments")
                        .WithMany("Employers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Company.Data.Entities.EmployersRoll", b =>
                {
                    b.HasOne("Company.Data.Entities.Employer", "Employers")
                        .WithMany("EmployersRolls")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Roll", "Rolls")
                        .WithMany("EmployersRolls")
                        .HasForeignKey("RollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employers");

                    b.Navigation("Rolls");
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Navigation("Employers");
                });

            modelBuilder.Entity("Company.Data.Entities.Employer", b =>
                {
                    b.Navigation("EmployersRolls");
                });

            modelBuilder.Entity("Company.Data.Entities.MyCompany", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Company.Data.Entities.Roll", b =>
                {
                    b.Navigation("EmployersRolls");
                });
#pragma warning restore 612, 618
        }
    }
}