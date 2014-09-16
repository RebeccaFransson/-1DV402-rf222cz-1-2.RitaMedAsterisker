using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritamedasterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            byte oddNumber; //triangel http://sharepoint2010mind.blogspot.se/2012/10/c-program-to-print-patterns-of-numbers.html
            int maxNumber = 79;

            do
            {
                oddNumber = ReadOddByte();
                RenderTriangle(oddNumber);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck på valfri tanget för att prova en gång till - Esc avslutar programmet.");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
        static byte ReadOddByte()
        {
            byte value = 0; //In this method we check if the input number is a odd number and less than 79. If its not, there vill be a catch
            string input;
            while (true)
            {
                Console.Write("Skriv in ett udda tal som är mindre än 79: ");
                input = Console.ReadLine();
                try
                {
                    value = byte.Parse(input);
                    if (value % 2 != 0 && value <= 79) //If value a odd number and less than 79, then break!
                    {
                        break;
                    }
                    throw new Exception();
                }
                catch //if the for doesnt work, then the catch will come up
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ditt tal '{0}' fungerar inte. Vänligen skriv ett udda tal som är mindre än 79.", input);
                    Console.ResetColor();
                }


            }
            return value;

        }

        static void RenderTriangle(byte cols) //
        {
           for (int row = 1; row <= cols; row += 2)
            {
                for (int withespaces = 0; withespaces < cols-row; withespaces += 2)
                {
                    Console.Write(" ");
                }

                for (int aster = 0; aster < row; aster++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

                //for (height = 1; height <= width; height++)             //triangel http://sharepoint2010mind.blogspot.se/2012/10/c-program-to-print-patterns-of-numbers.html
                //{
                //    for (c = 1; c < temp; c++)
                //        Console.Write(" ");

                //    temp--;
                //    for (c = 1; c <= 2 * height - 1; c++)
                //        Console.Write("*");

                //    Console.WriteLine();

                //}

        }
    }
}