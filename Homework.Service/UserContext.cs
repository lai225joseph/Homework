using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework.Domain;

namespace Homework.Service
{
    public class UserContext : DbContext, IUserContext
    {
        public UserContext()
        {
            Database.SetInitializer<UserContext>(null);
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Configuration.ValidateOnSaveEnabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            Configuration.LazyLoadingEnabled = false;
            base.Dispose(disposing);
        }

        public DbSet<User> User { get; set; }
    }
}
