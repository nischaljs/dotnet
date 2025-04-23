// Interface defining basic vehicle operations
public interface IVehicle 
{
    void Register();
    void Start(); 
    void Stop();
    void PlayHorn();
}

// Car class implementing IVehicle interface
public class Car : IVehicle
{
    public void Register()
    {
        Console.WriteLine("New car registered");
    }
    public void Start()
    {
        Console.WriteLine("Car has started");
    }
    public void Stop()
    {
        Console.WriteLine("Car has stopped");
    }
    public void PlayHorn()
    {
        Console.WriteLine("Car says....., beep beep");
    }
}

// Abstract cycle class implementing IVehicle interface
public abstract class Cycle : IVehicle
{
    // Implemented method
    public void Start()
    {
        Console.WriteLine("Cycle has started");
    }

    // Abstract methods that must be implemented by derived classes
    public abstract void Register();
    public abstract void Stop();
    public abstract void PlayHorn();
}

// Concrete cycle class implementing all abstract methods
public class BasicCycle : Cycle
{
    public override void Register()
    {
        Console.WriteLine("New cycle registered");
    }

    public override void Stop()
    {
        Console.WriteLine("Cycle has stopped");
    }

    public override void PlayHorn()
    {
        Console.WriteLine("Cycle says... ring ring");
    }
}

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Creating and using a Car instance
        IVehicle car = new Car();
        car.Start();
        car.PlayHorn();

        // Creating and using a Cycle instance
        IVehicle cycle = new BasicCycle();
        cycle.Start();
        cycle.PlayHorn();
    }
}