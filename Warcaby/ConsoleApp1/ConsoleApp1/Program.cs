using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dane w formacie (nazwisko, imie (abcd/123) +48 123 456 888)");
            string a;
            a = Console.ReadLine();
            Console.WriteLine(a.Split(','));
            
        }
    }
}
