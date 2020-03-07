using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Szia!");
            int titkos = r.Next(1, 100);
            Console.WriteLine("Gondoltam egy számra, ha szorzom önmagával, akkor "+titkos*titkos+"-t kapok!");

            int szamom = Convert.ToInt32(Console.ReadLine());

            while (szamom != titkos)
            {
                Console.WriteLine("Próbáld újra: ");
                if(szamom > titkos)
                {
                    Console.WriteLine("Túl nagy számot adtál meg :D");
                }
                if(szamom < titkos)
                {
                    Console.WriteLine("Ettől nagyobb számot adj meg :D");
                }
                szamom = Convert.ToInt32(Console.ReadLine());
                if (szamom == titkos)
                {
                    break;
                }
            }
            Console.WriteLine("Sikerült");

        

            Console.ReadKey();
        }
    }
}
