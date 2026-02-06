using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teeme regular expression harjutuse");

            string word = "#CD53C5C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Kas on regex: " + RegExTest(word));

            //tee regex, mis on false tulemusega
            //põhjenda, miks ära, et miks see false on
        }

        public static bool RegExTest(string word)
        {
            //Regular Expression kontrollib, kas sisestatav string vastab nõuetele
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
