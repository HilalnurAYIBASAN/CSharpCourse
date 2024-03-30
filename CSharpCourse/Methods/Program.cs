﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            ////var result= Add2(20,30);
            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);  //ref(out'un da mantığı aynıdır); değer tipleri referans tip gibi kullanmaya yarar

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(2,3,6,8,3,45));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number2 + number1;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}