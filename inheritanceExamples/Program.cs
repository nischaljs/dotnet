namespace inheritanceExamples
{
    public class Program{
        public static void Main(String[] args){
            Console.WriteLine("hello");
            Student p = new Student();
            p.roll=12;
            p.salary=450.9;
            Console.WriteLine($"Roll: {p.roll ?? 0}, Salary: {p.salary ?? 0}");

        }
    }
} 