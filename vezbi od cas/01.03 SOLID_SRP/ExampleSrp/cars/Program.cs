using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleSrp.TheBad;
using ExampleSrp.TheGood;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer newBuyer = new Buyer();
            //Logger log = new Logger();
            ILoggerInterface log = Logger.GetLogger();
            newBuyer.SetLoggers(log);
            ILoggerInterface logger = newBuyer.Log();
            AcmeCar car = new AcmeCar(logger);
            car.StateChanged += car_StateChanged;
            car.ErrorHappened += car_ErrorHappened;
            car.Lock();
            car.Unlock();

        }

        static void car_ErrorHappened(object sender, CarExceptionEventArguments args)
        {
            ILoggerInterface logger = args.log;
            logger.CarException(args.Error);
        }
      
        static void car_StateChanged(object sender, CarStateChangedEventArguments args)
        {
            ILoggerInterface logger = args.log;
            logger.CarState(args.carState);
        }
    }
}
