using Register.Common.Interfaces;
using Register.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DataLayer
{
    public interface IRegisterContext : IDisposable, IContext
    {
        IDbSet<Bike> Bikes { get; set; }
    }
}
