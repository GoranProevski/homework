using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleSrp.TheGood;

namespace ExampleSrp.TheBad
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        public ILoggerInterface logger { get; set; }

        public event CarStateChanged StateChanged;
        public event CarException ErrorHappened;
        protected virtual void OnStateChanged(CarStateChangedEventArguments e)
        {
            if (StateChanged != null)
                StateChanged(this, e);
        }

        protected virtual void OnErrorHappened(CarExceptionEventArguments e)
        {
            if (ErrorHappened != null)
                ErrorHappened(this, e);
        }
        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                //StatusLogger statLog = new StatusLogger();
                //statLog.CarChangedState(IsLocked.ToString());
                //logger.CarState("Locked");
                CarStateChangedEventArguments arg = new CarStateChangedEventArguments(IsLocked.ToString(), logger);
                OnStateChanged(arg);
                

            }
            catch (Exception)
            {
                //ExceptionLogger excLog = new ExceptionLogger();
                //excLog.ExceptionLog("There was an error Locking the car");
                logger.CarException("Couldn't be locked");
                CarExceptionEventArguments arg = new CarExceptionEventArguments("Couldn't be locked", logger);
                OnErrorHappened(arg);


            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                
                //StatusLogger statLog = new StatusLogger();
                //statLog.CarChangedState(IsLocked.ToString());
                //logger.CarState("Unlocked");
                CarStateChangedEventArguments arg = new CarStateChangedEventArguments(IsLocked.ToString(), logger);
                OnStateChanged(arg);
            }
            catch (Exception)
            {
                //ExceptionLogger excLog = new ExceptionLogger();
                //excLog.ExceptionLog("There was an error unlocking the car");
                //logger.CarException("Couldn't be unlocked");
                CarExceptionEventArguments arg = new CarExceptionEventArguments("Couldn't be unlocked", logger);
                OnErrorHappened(arg);
            }

        }

        public AcmeCar(ILoggerInterface logg)
        {
            this.logger = logg;
        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}
