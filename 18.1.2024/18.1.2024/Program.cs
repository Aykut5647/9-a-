using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _18._1._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers .Split(' ', ',', '.');
            Console.WriteLine("Available beers are:");
            foreach (string beer in beers)
                Console.WriteLine(beer);
            string Защо = "Az,Aykut,obicham,da,piq,voda";
            string[] защото = Защо.Split(' ', ',', '.');
            Console.WriteLine("Завирших, защото:");
            foreach (string Aykut in защото)
                Console.WriteLine(Aykut);
            string replaced = listOfBeers.Replace(",", " ");
            //Vodka and Martini and Cherry
            Console.WriteLine(replaced);
            string novo = replaced.Remove(8, 8);
            Console.WriteLine(novo);
            string lowerAlpha = novo.ToLower();
            Console.WriteLine(lowerAlpha);
            string upperAlpha = novo.ToUpper();
            Console.WriteLine(upperAlpha);
            
            string novo1 = Защо.Replace("voda", "maze");
            string novo2 = Защо.Remove(24, 4);
            Console.WriteLine(novo2);
            string lowerAlpha1 = Защо.ToLower();
            Console.WriteLine(lowerAlpha1);
            string upperAlpha2 = Защо.ToUpper();
            Console.WriteLine(upperAlpha2);
        }   
    }
}
