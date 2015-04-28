using Register.BusinessLayer.Contracts;
using Register.Common;
using Register.DomainModel;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BusinessLayer.Handlers
{
    internal class UserDisplayCommandHandler : CommandHandlerBase<UserDisplayCommand, UserDisplayResult>
    {
        protected override UserDisplayResult ExecuteCommand(UserDisplayCommand command)
        {
            IUserRepository repo = RepositoryManager.CreateRepository<IUserRepository>();

            UserDisplayResult result = new UserDisplayResult();

            result.Users = repo.GetAll() as List<User>;

            return result;

        }
    }
}
