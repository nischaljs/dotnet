public class Program{
    public static void Main(string[] args){
       Program p = new Program();
       p.show();
       GC.Collect();

    }
    public void show(){
    Student s1= new Student();
       s1.SetRoll(5);
       Console.WriteLine("Roll : "+s1.getRoll());
    }
}
