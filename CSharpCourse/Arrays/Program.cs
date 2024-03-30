using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays;

class Program
{
    static void Main(string[]args)
    {
        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Hilal";
        students[2] = "Salih";

        //string[] students2 = new[] {"Engin", "Hilal", "Salih"}; 

        //string[] students2 = {"Engin", "Hilal", "Salih"}; 

        //foreach (var  student in students)
        //{
        //    Console.WriteLine(student);
        //}

        string[,] regions = new string[5, 3]
        {
            {"İstanbul","İzmir","Balıkesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mesin"},
            {"Rize","Tarbzon","Samsun"},
            {"İzmir","Muğla","Manisa"}

        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("**********");
        }

        Console.WriteLine();
        Console.ReadLine();
    }
}