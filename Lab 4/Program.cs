using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static long Factorial()
        {
            int Input = Convert.ToInt32(Console.ReadLine());
            long product = 1; 
            for (int i = (Input); i > 1; i--)
            {
                product = product * i;


            }
            return product;
        }

        static void Main(string[] args)
        {
            string run;
            do
            {
                { 
                Console.WriteLine("Enter an intiger between 1 and 63:");
                    
                   long result = Factorial();
                Console.WriteLine("Factorial:"+result);

                }

                Console.WriteLine("Do you want to Continue y/n?");
                run = Console.ReadLine();
            }
            while (run == "y");
        }




    }
}
