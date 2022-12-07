using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;                        //to get access to future entity classes.
using Microsoft.EntityFrameworkCore;                //to get access to database functionality needed to wotk with entitiesand to get access the DbContextOptions
                                                    //class, which is required by EF Core when adding constructors to the database context.


namespace Company.Data.Contexts
{
    /// <summary>
    /// This class is the bridge between the database and the application.All database connections uses this class to
    /// communicate with the database because it contains properties for all entity classes, which
    /// represents the tables in the database.
    ///
    /// CourseContext inherits the DbContext class to make it a context EF Core can 
    /// use to communicate with the database.
    /// </summary>
    public class CompanyContext : DbContext
    {
        //Här definieras namnen för tabellerna i databasen och "tilldelas" rätt klass i VS
        public DbSet<MyCompany> Companies => Set<MyCompany>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employer> Employers => Set<Employer>();
        public DbSet<Roll> Rolls => Set<Roll>();
        public DbSet<EmployersRoll> EmployersRolls => Set<EmployersRoll>();

        /// <summary>
        /// EF requires a constructor with a DbContextOptions<CourseContext> parameter named 
        /// options even though you won’t use it.Pass the options parameter to the IdentityDbContext
        /// base class with the base keyword.
        /// </summary>
        /// <param name="options"></param>
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        /// <summary>
        /// Use this method to configure certain features of the database and call a 
        /// method to seeds data in the database when it is created.
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmployersRoll>().HasKey(ci =>
                new { ci.EmployerId, ci.RollId });

            SeedData(builder);

        }

        /// <summary>
        /// To have some data to work with, you seed them with data from this method
        /// </summary>
        /// <param name="builder"></param>
        private void SeedData(ModelBuilder builder)
        {
            var companies = new List<MyCompany>
            {
                 new MyCompany {Id = 101, Companyname = "MittFöretag_S", Organisationno = "123456-7890", Land = "Sverige"},
                 new MyCompany {Id = 102, Companyname = "MittFöretag_D", Organisationno = "567890-2345", Land = "Danmark"}
            };

            var departments = new List<Department>
            {
                 new Department {Id = 1001, Departmentname = "IT_S",             CompanyId = 101},
                 new Department {Id = 1002, Departmentname = "Ekonomi_S",        CompanyId = 101},
                 new Department {Id = 1003, Departmentname = "Administration_S", CompanyId = 101},
                 new Department {Id = 1004, Departmentname = "Styrelse_S",       CompanyId = 101},
                 new Department {Id = 1005, Departmentname = "IT_D",             CompanyId = 102},
                 new Department {Id = 1006, Departmentname = "Ekonomi_D",        CompanyId = 102},
                 new Department {Id = 1007, Departmentname = "Styrelse_D",       CompanyId = 102}
            };

            var employers = new List<Employer>
            {
                 new Employer {Id = 11, Firstname = "Kalle", Lastname = "Anka",       Sallary = 50000, UnionMember = true,  DepartmentId = 1001},
                 new Employer {Id = 12, Firstname = "Bamse", Lastname = "Björn",      Sallary = 46000, UnionMember = true,  DepartmentId = 1002},
                 new Employer {Id = 13, Firstname = "Pelle", Lastname = "Svanslös",   Sallary = 34000, UnionMember = false, DepartmentId = 1003},
                 new Employer {Id = 14, Firstname = "Kajsa", Lastname = "Kavat",      Sallary = 32000, UnionMember = true,  DepartmentId = 1001},
                 new Employer {Id = 15, Firstname = "Nils",  Lastname = "Pyssling",   Sallary = 35000, UnionMember = false, DepartmentId = 1004},
                 new Employer {Id = 16, Firstname = "Mamma", Lastname = "Mu",         Sallary = 41000, UnionMember = true,  DepartmentId = 1005},
                 new Employer {Id = 17, Firstname = "Great", Lastname = "Gris",       Sallary = 40000, UnionMember = false, DepartmentId = 1006},
                 new Employer {Id = 18, Firstname = "Pippi", Lastname = "Långstrump", Sallary = 38000, UnionMember = true,  DepartmentId = 1007}
            };

            var employersrolls = new List<EmployersRoll>
            {
                 new EmployersRoll {EmployerId = 11, RollId = 1},
                 new EmployersRoll {EmployerId = 11, RollId = 5},
                 new EmployersRoll {EmployerId = 12, RollId = 3},
                 new EmployersRoll {EmployerId = 13, RollId = 5},
                 new EmployersRoll {EmployerId = 13, RollId = 7},
                 new EmployersRoll {EmployerId = 14, RollId = 2},
                 new EmployersRoll {EmployerId = 15, RollId = 4},
                 new EmployersRoll {EmployerId = 16, RollId = 1},
                 new EmployersRoll {EmployerId = 17, RollId = 6},
                 new EmployersRoll {EmployerId = 18, RollId = 4}

            };

            var rolls = new List<Roll>
            {
                 new Roll {Id = 1, Rollname = "Utvecklare"},
                 new Roll {Id = 2, Rollname = "Databasadministratör"},
                 new Roll {Id = 3, Rollname = "Lönespecialist"},
                 new Roll {Id = 4, Rollname = "VD"},
                 new Roll {Id = 5, Rollname = "Teamchef"},
                 new Roll {Id = 6, Rollname = "Redovisningsekonom"},
                 new Roll {Id = 7, Rollname = "Administratör"}

            };

            builder.Entity<MyCompany>().HasData(companies);
            builder.Entity<Department>().HasData(departments);
            builder.Entity<Employer>().HasData(employers);
            builder.Entity<EmployersRoll>().HasData(employersrolls);
            builder.Entity<Roll>().HasData(rolls);

        }
    }
}
