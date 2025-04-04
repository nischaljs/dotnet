using System;

public class Student
{
    private int roll;
    private string? name;

    public string Var
    {get{
        return value;
    }
    set{
        var
    }}
    private int? age;

// a constructor of the student class that gets called when an object of this class is being created
    public Student(){
        Console.WriteLine("The object of student is being created");
    }

    public void SetRoll(int roll){
        if (roll < 0)
        {
            Console.WriteLine("Roll number cannot be negative.");
        }
        else
        {
            this.roll = roll;
        }
    }

// a destructor that gets called when the gargbage collector cleans up this object from heap.
     ~Student(){
        Console.WriteLine("The objec is being destroyed");
    }

    public int getRoll () {
        return this.roll;
    }
}