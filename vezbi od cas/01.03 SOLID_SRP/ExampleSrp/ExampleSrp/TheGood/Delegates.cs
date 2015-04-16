
using ExampleSrp.TheGood;
public class CarStateChangedEventArguments : System.EventArgs
{
    public string carState { get; set; }
    public ILoggerInterface log { get; set; }

    public CarStateChangedEventArguments(string s, ILoggerInterface logger)
    {
        this.carState = s;
        this.log = logger;
    }
}

public delegate void CarStateChanged(object sender, CarStateChangedEventArguments args);

public class CarExceptionEventArguments : System.EventArgs
{
    public string Error { get; set; }
    public ILoggerInterface log { get; set; }
    public CarExceptionEventArguments(string s, ILoggerInterface logger)
    {
        this.Error = s;
        this.log = logger;
    }
}

public delegate void CarException(object sender, CarExceptionEventArguments args);