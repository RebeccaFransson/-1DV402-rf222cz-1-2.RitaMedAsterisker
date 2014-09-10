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
            byte value = 0; //In this methos we check if the input number is a odd number and less than 79. If its not, there vill be a catch
            string input;
            while (true)
            {
                Console.Write("Skriv in ett udda tal som är mindre än 79: ");
                input = Console.ReadLine();
                try
                {
                    value = byte.Parse(input);
                    if (value % 2 != 0 && value <= 79) //If value a odd number and less than 79, then break!               ??? hur value <=79?????
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

        static void RenderTriangle(byte cols)
        {

            int n, c, row, temp;
            row = ReadOddByte();
            temp = row;
            for (n = 1; n <= row; n++)
            {
                for (c = 1; c < temp; c++)
                    Console.Write(" ");

                temp--;
                for (c = 1; c <= 2 * n - 1; c++)
                    Console.Write("*");

                Console.WriteLine();
           }
        }
    }
}