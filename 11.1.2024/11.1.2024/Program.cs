using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = int.Parse(Console.ReadLine());
            string pol = Console.ReadLine();
            if (age < 16)
            {

                if (pol == "M") Console.WriteLine("Master");
                else if (pol == "f") Console.WriteLine("Miss");
            }
            else
            {
                if (pol == "M") Console.WriteLine("Mr.");
                else if (pol == "f") Console.WriteLine("Ms.");
            }
        }
    }
}
