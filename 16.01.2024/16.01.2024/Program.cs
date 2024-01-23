using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._01._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vivedi si imeto");
            string name = (Console.ReadLine());
            Console.WriteLine("Hi," + name);
            string str = " Hello, 9a";
            string str1 = new string(new char[] { 'O','h',','});
            char[] charArr = str.ToCharArray();
            string str2 = string.Concat(str1, str);
            string str3= new string(charArr);
            Console.WriteLine(str2);
        }
    }
}
