using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyLibrary.FodboldCase;

namespace FodboldCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Antal afleveringer");
            //Bruger input, hvor mange afleveringer. Int32.Parse konverterer string til int32.
            var afleveringer = Int32.Parse(Console.ReadLine());

            Console.WriteLine("er der mål?");
            var mål = Console.ReadLine();

            //nyt objekt a1 med variablerne afleringer og mål.
            Afleveringer a1 = new Afleveringer(afleveringer, mål);

            //udskriver objektet a1 med metoden JubelScenarier
            Console.WriteLine(a1.JubelScenarier());

            Console.ReadKey();

        }
    }
}
