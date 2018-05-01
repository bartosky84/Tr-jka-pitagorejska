using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Program sprawdzajacy czy podane liczby są wyznacznikami trojka pitagorejska");

            Console.WriteLine("Podaj liczbę a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = double.Parse(Console.ReadLine());

            if((a*a+b*b)==c*c)
            {
                Console.Write("Liczby");
                Console.Write("a=" + a + "  b=" + b + "  c=" + c);
              
                Console.Write(" Są trojką pitagorejska ");
                
            }
            else
            {
                Console.Write("Liczby ");
                Console.Write("a=" + a + "  b=" + b + "  c=" + c);

                Console.Write(" Nie są trojką pitagorejska ");
  

            }
            Console.Read();
        }
    }
}
