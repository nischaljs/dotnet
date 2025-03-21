using System;

public class Program {
    public static void Main() {
        int[] num = new int[10];
        Console.Clear();
        
        for (int i = 0; i < num.Length; i++) {
            Console.WriteLine("Enter {0}th number:", i + 1);
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Your numbers are given below:");
        foreach (int n in num) {
            Console.Write(n + "\t");
        }
    }
}
