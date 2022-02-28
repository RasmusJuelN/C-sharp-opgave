using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyLibrary.DanseCase;


namespace DanseKonkurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast første dansers navn");
            var navn1 = Console.ReadLine();
            Console.WriteLine("Indtast score");
            var point1 = Int32.Parse(Console.ReadLine());

            //Objekt for den første danser, indeholder navn og antal point.
            DancerPoint danser1 = new DancerPoint(navn1, point1);

            Console.WriteLine("Indtast anden dansers navn");
            var navn2 = Console.ReadLine();
            Console.WriteLine("Indtast score");
            var point2 = Int32.Parse(Console.ReadLine());

            //Obejkt for anden danser.
            DancerPoint danser2 = new DancerPoint(navn2, point2);

            //Objekt for samlet, danser1 og danser2 kan adderes pga. Operator+.
            DancerPoint samlet = (danser1 + danser2);

            //Udskriver værdien af obejkt samlet, samt metoden "SamletScoreForDansere"'s return.
            Console.WriteLine(samlet.SamletScoreForDansere());
            Console.ReadKey();


        }
    }
}

