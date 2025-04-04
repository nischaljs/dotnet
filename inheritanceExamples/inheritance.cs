namespace inheritanceExamples
{
    public class Person{
        protected string? Name;
        protected int? age ;
        public double? salary
        {get;set;}
    }
    public class Student :Person
    {
        public int? roll;
        public string? character 
        {get;set;}
    }
}