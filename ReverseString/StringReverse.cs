namespace ReverseString{
    public class Program 
    {
        public static void Main(string[] args){
            console.WriteLine("Enter a string");
            string myStr = Convert.ToString(Console.ReadLine())??String.Empty;
            Console.WriteLine("Reversed string is :" + ReverseString(myStr));
        }
        public static string ReverseString(string str){
            //using string directly but leads to creation of significant number of string causing problems
            // string rev = string.Empty;
            // for(int i = str.length-1; i>=0;i--){
            //     rev+=str[i];
            // }
            // return rev;

            //using stirng builders
            StringBuilder sb = new StringBuilder(0;
            )
        }
    }
}