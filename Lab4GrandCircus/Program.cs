



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Learn Your Squares and Cubes  ! \n");

            //doContinue 
            bool toContinue = true;

            // loop the program
            while (toContinue)
            {
                // user input
                Console.Write("\n Enter a integer: ");

                int number = Convert.ToInt16(Console.ReadLine());

                // display output number,square,cubed
                var header = String.Format("{0,6}{1,8}{2,8}\n", " Number ", " Square ", " Cubed ");

                Console.WriteLine(header);

                // do math through loop converting math problems
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("{0, -8} {1, -10} {2, -6}", i, Math.Pow(i, 2), i * i * i);
                }

                // continue yes or no 
                Console.Write("\n\n  Continue? Y/N\t");

                var userInput = Console.ReadKey().KeyChar;

                if (userInput != 'Y')
                {
                    toContinue = false;

                    Console.WriteLine("\n Exiting Program.");
                }
            }

            Console.ReadKey();
        }
    }
}