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
    internal class BikeRepository : IBikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes()
        {
            using (var context = ContextManager.CreateContext<IRegisterContext>()) 
            { 
                
            }

            throw new NotImplementedException();
        }


        public IList<DomainModel.Bike> GetAll()
        {
            using (var context = ContextManager.CreateContext<IRegisterContext>())
            {
                IList<DomainModel.Bike> bikes = context.Bikes.OrderBy(x => x.Company).ToList();
                //logger.LogIt("this is from DL");
                return bikes;
            }
        }
    }
}
