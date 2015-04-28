using Register.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.DataLayer;
//using Register.DataLayer.models;
using Register.DomainModel;
using Register.DomainModel.Logging;
using Register.Repository.Interfaces;
using Register.Common;

namespace Register.BusinessLayer.Handlers
{
    class BikeDisplayCommandHandler : CommandHandlerBase<BikeDisplayCommand, BikeDisplayResult>
    {
        protected override BikeDisplayResult ExecuteCommand(BikeDisplayCommand command)
        {
            //string s = command.Action;
            //Logger myLogger = new Logger();
            //myLogger.LogIt("about to enter DL");
            //RegisterContext context = new RegisterContext();
            //BikeDAL bikeDA = new BikeDAL(context, myLogger);
            //IEnumerable<Bike> result = bikeDA.GetBikes();
            //BikeDisplayResult allbikes = new BikeDisplayResult(result);
            //myLogger.LogIt("returning to BL");
            //return allbikes;

            IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();

            BikeDisplayResult result = new BikeDisplayResult();

            result.bikes = repo.GetAll() as List<Bike>;

            return result;
        }
    }
}