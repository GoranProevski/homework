using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DataLayer
{
    public class ContextFactory : IContextFactory
    {
        public TContext CreateContext<TContext>() where TContext : IContext
        {
            if (typeof(TContext) == typeof(IRegisterContext))
            {
                return (TContext)(object)new RegisterContext();
            }

            if (typeof(TContext) == typeof(IUserContext))
            {
                return (TContext)(object)new UserContext();
            }

            return default(TContext);
        }
    }
}
