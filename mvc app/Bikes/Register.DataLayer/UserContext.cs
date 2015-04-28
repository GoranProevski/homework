using Register.DataLayer.models.Mapping;
using Register.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DataLayer
{
    public class UserContext : DbContext, IUserContext
    {

        static UserContext() 
        {
            Database.SetInitializer<RegisterContext>(null);
        }

        public UserContext() : base("Name=UserContext")
        {

        }

        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
