using Register.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BusinessLayer.Contracts
{
    public class UserDisplayResult : CommandResult
    {
        public List<User> Users { get; set; }
    }
}
