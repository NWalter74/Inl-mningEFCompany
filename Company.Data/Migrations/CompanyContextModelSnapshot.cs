﻿// <auto-generated />
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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