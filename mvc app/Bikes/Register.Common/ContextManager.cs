using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common
{
    public static class ContextManager
    {
        private static IContextFactory contextFactory;

        public static TContext CreateContext<TContext>() where TContext : IContext 
        {
            TContext result = contextFactory.CreateContext<TContext>();
            return result;
        }

        public static void RegisterContextFactory(IContextFactory factory) 
        {
            contextFactory = factory;
        }
    }
}
