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

        }
    }
}
