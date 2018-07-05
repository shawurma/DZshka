using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
          int n = 5;
           int factorial = 1; 
           for (int i = 2; i <= n; i++) 
           { factorial = factorial * i; }
            Console.WriteLine("Полученый факториал из"  + n +" = " + factorial);
    }
}
}