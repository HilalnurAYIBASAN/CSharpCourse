using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Hilal";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is clon hilal";

            bool result3 = sentence.EndsWith("l");
            bool result4 = sentence.StartsWith("m");

            var result5 = sentence.IndexOf("y"); //kaçıncı karakterde var (ctrlf) e benzer özellik gösterir.
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello, ");// şu indexten itibaren şunu yazdır.
            var result9 = sentence.Substring(3,4);//şu metnin belli bir yerinden sonra şu değeri al demektir. metni parçalamak demektir
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");//bir ifadenin yerini değiştir
            var result13 = sentence.Remove(2, 4);//belli bir indexten sonrasını atmak için kullanılır.


            Console.WriteLine(result9);
            //Console.WriteLine(result2);//My name is Hilal, bunu yazdırıyor.
            //Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Console.WriteLine(result);
        }
    }
}

