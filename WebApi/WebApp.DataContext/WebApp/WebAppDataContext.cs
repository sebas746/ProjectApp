using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.WebApp
{
    public class WebAppDataContext : DbContext
    {
        public WebAppDataContext()
            : base("name=WebAppDataContext")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CoverageType> CoverageType { get; set; }
        public DbSet<RiskType> RiskType { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Client> Clients { get; set; }

        public virtual ObjectResult<LoginByUsernamePassword_Result> LoginByUsernamePassword(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));

            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginByUsernamePassword_Result>("LoginByUsernamePassword", usernameParameter, passwordParameter);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m =>
                {
                    m.ToTable("UserRoles");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");
                });
        }
    }
}
