// note: This program uses List syntax where a List is created and a for loop is used to iterate through the list.
// List is different from array 



namespace LINQDEMO
{
    class Program{
        static void Main(string[] args){
            List <int> integerList = new List <int> () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var MethodSyntax = integerList.Where(obj => obj >5).ToList();
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}