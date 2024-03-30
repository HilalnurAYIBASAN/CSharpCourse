using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForechLoop();
        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number.");
        }
        else
        {
            Console.WriteLine("This is a not prime number.");
        }

        Console.ReadLine();
    }

    private static bool IsPrimeNumber(int number)//PrimeNumber asal sayı demek
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number%i==0)
            {
                result = false;
                i= number;
            } 
        }
        return result;
    }

    private static void ForechLoop()
    {
        string[] students = new[] { "Engin", "Hilal", "Salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;

        } while (number >= 11);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
    }

    private static void ForLoop()
    {
        for (int i = 0; i <= 100; i += 10)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished!");
    }
}