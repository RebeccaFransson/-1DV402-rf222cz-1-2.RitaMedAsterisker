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
              const int maxNumber = 79;

            do
            {
                oddNumber = ReadOddByte(ConsoleApplication1.Properties.Resources.Write,maxNumber);
                RenderTriangle(oddNumber);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(ConsoleApplication1.Properties.Resources.Continue_prompt);
                Console.ResetColor();

            } while (IsCounting());

        }
        static bool IsCounting() { 
           return  Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
        static byte ReadOddByte(string prompt = null, int maxNumber = 255)
        {
            byte value = 0; //In this method we check if the input number is a odd number and less than 79. If its not, there vill be a catch
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                try
                {
                    value = byte.Parse(input);
                    if (value % 2 != 0 && value <= maxNumber) //If value a odd number and less than 79, then break!
                    {
                        break;
                    }
                    throw new Exception();
                }
                catch //if the for doesnt work, then the catch will come up
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(ConsoleApplication1.Properties.Resources.Error, input);
                    Console.ResetColor();
                }


            }
            return value;

        }

        static void RenderTriangle(byte cols) 
        {
            byte cols2 = cols;    
           for (int row = 1; row <= cols; row += 2) // 
            {
                RenderRow(row, cols);

                Console.WriteLine();


            }

           for (int row = cols2-1; row > 0; row-= 2) // 
           {
              
               RenderRow(row-1, cols2);
               Console.WriteLine();


           }

        }

            static void RenderRow(int row, int cols)
            {
               for (int withespaces =0; withespaces < cols-row; withespaces += 2)  // 5(cols)-3(row)=2(withespace)
               {
                   Console.Write(" ");
               }

               for (int aster = 0; aster < row; aster++)
               {
                   Console.Write("*");
               }

            }
    }
}