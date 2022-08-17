using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "nazwisko, imie (abcd/123) +48 123 456 888";
            string[] newStr = data.Trim().Split(',', '(', '/', ')');
            if (newStr.Length == 5)
            {
                foreach (var str in newStr)
                {
                    Console.WriteLine(str.TrimStart());
                }
            }
            else
            {
                Console.WriteLine("Dane w niepoprawnym formacie (nazwisko, imie (abcd/123) +48 123 456 888)");

            }
        }
    }
}
