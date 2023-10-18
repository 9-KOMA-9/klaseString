using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringEdi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danas radimo sa klasom String";
            //ispis stringa
            Console.WriteLine(tekst);
            //broja znakova u stringu
            Console.WriteLine("Broj znakova u stringu je: " + tekst.Length);
            //Ispis velikih slova u stringu
            Console.WriteLine("Velika slova: " + tekst.ToUpper());
            //ispis malim slovima
            Console.WriteLine("Velika slova: " + tekst.ToLower());
            //substring metoda
            Console.WriteLine("\n --Substring metoda--");
            Console.WriteLine(tekst.Substring(0, 5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));
            //zamjena znakova
            Console.WriteLine("\n --zamjena --");
            Console.WriteLine(tekst.Replace("Danas", "  Sutra"));
            // Razdvajanje stringa u više stringova
            Console.WriteLine("\n -- Razdvajanje --");
            string[] rijeci = tekst.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }
            foreach(string rijec in rijeci)
            {
                Console.WriteLine(rijeci);

            }
            //umetanje znakova u string
            Console.WriteLine("\n -- umetanje --");
            Console.WriteLine(tekst.IndexOf("radimo"));
            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"), "intenzivno "));




            Console.ReadKey();
        }
    }
}
