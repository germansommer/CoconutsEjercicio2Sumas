using System;

namespace CocoSumas02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int num1 = 0, num2= 0, res = 0, i;
            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (num1 < 1);
            do
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (num2 < 1);            
            Console.WriteLine("******************************");            
            for (i = 0; i < num2; i++)
            {
                res += num1;
                Console.WriteLine(num1 + "x" + (i+1) + "= " + res);
            }
        }
    }
}
