using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            int prviInt = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int drugiInt = int.Parse(Console.ReadLine());

            float prviFloat = prviInt;
            float drugiFloat = drugiInt;

            var kolicnik1 = prviInt / drugiInt;
            var kolicnik2 = prviFloat / drugiFloat;
            var kolicnik3 = (float)prviInt / drugiInt;

            Console.WriteLine($"{prviInt}/{drugiInt}={kolicnik1}");
            Console.WriteLine($"{prviFloat}/{drugiFloat}={kolicnik2}");
            Console.WriteLine(kolicnik1.ToString);
            Console.ReadLine();


        }
    }
}

