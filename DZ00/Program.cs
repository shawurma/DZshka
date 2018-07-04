using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,res;
           // int res;
            char znack;          
            Console.WriteLine("Введите чиcло");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие");
            znack = Convert.ToChar(Console.ReadLine());
            if(znack == '+')
                {res = a + b;
                Console.WriteLine("Сумма:"+res);
            }
                else if(znack == '-')
                {res = a - b;
                Console.WriteLine("Разность:"+res);
            }
                else if(znack == '*')
                {res = a * b;
                Console.WriteLine("Произведение:"+res);
            }
                else if(znack == '/')
                {res = a / b;
                Console.WriteLine("Деление:"+res);
            }

    }
  }
}