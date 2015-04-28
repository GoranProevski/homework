using Register.Common;
using Register.DataLayer;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository
{
    internal class UserRepository : IUserRepository
    {
        public IList<DomainModel.User> GetAll()
        {
            using (var context = ContextManager.CreateContext<IUserContext>())
            {
                IList<DomainModel.User> users = context.Users.OrderBy(u => u.FirstName).ToList();
                return users;
            }
        }
    }
}
