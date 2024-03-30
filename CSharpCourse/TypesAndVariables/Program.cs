using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main()
        {
            //Value Types
            //Console.WriteLine("Hello Word!");
            string days = "Monday";
            double number8 = 10.4;
            decimal number9 = 10.4m;
            char character = 'A';
            string city = "Ankara";
            bool condition = false;
            byte number7 = 255; //1bit (0 ile 255 arasında değer alır)
            short number5 = -32768;//16bit
            short number6 = 32767;
            int number1 = 2147483647;
            int number2 = -2147483648;//32bit
            long number3 = -9223372036854775808;//64bit
            long number4 = 9223372036854775807;
            var number10 = 10; //int değer veridin STRİNG versen de int algılar
            number10 = 'A';
           
            Console.WriteLine("Number1 and Number2 {0} {0}", number1, number2);  
            Console.WriteLine("Number3 {0}", number3);
            Console.WriteLine("Character is: {0}" , (int)character);
            Console.WriteLine("Number8 {0}", number8);
            Console.WriteLine("Number9 {0}", number9);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();

             
        }
    }
    enum Days
    {
        Monday=10, Tuesday=20, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}