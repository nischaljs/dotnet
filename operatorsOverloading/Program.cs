using System;

public class Distance
{
    public int meters;      
        public int centimeters; 

    // Constructor to initialize Distance object
    public Distance(int m, int cm)
    {
        // Convert excess centimeters into meters automatically
        meters = m + cm / 100;  // If cm >= 100, carry over to meters
        centimeters = cm % 100;  // Keep the remainder as centimeters
    }

    // 1️⃣ Java-style approach: Method-based addition (Simulates how Java does it)
    public Distance Add(Distance d)
    {
        // Convert both distances to total centimeters
        int totalCm = (this.meters * 100 + this.centimeters) + (d.meters * 100 + d.centimeters);
        
        // Convert back to meters and centimeters
        return new Distance(totalCm / 100, totalCm % 100);
    }

    // 2️⃣ Java-style alternative: Static method-based addition
    public static Distance Add(Distance d1, Distance d2)
    {
        int totalCm = (d1.meters * 100 + d1.centimeters) + (d2.meters * 100 + d2.centimeters);
        return new Distance(totalCm / 100, totalCm % 100);
    }

    // 3️⃣ C#-style approach: Overloading the + operator (Recommended in C#)
    public static Distance operator +(Distance d1, Distance d2)
    {
        int totalCm = (d1.meters * 100 + d1.centimeters) + (d2.meters * 100 + d2.centimeters);
        return new Distance(totalCm / 100, totalCm % 100); 
    }

    // Display method to print distance values
    public void DisplayDistance()
    {
        Console.WriteLine($"Meters: {meters}, Centimeters: {centimeters}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // Creating two Distance objects
        Distance d1 = new Distance(5, 50);
        Distance d2 = new Distance(3, 70);

        // Java-style method-based addition
        Distance d3 = d1.Add(d2);
        Console.Write("d1 + d2 using d1.Add(d2) (Java-style): ");
        d3.DisplayDistance();

        // Java-style static method-based addition
        Distance d4 = Distance.Add(d1, d2);
        Console.Write("d1 + d2 using Distance.Add(d1, d2) (Java-style): ");
        d4.DisplayDistance();

        // C#-style operator overloading 
        Distance d5 = d1 + d2;
        Console.Write("d1 + d2 using overloaded + operator (C#-style): ");
        d5.DisplayDistance();
    }
}
