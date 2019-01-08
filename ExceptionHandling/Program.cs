using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rdn = new Random();
            int secNum = rdn.Next(1, 5);
            int guessNum = 0;

            do
            {
                Console.Write("Enter a number between 1 and 5 : ");
                guessNum = Convert.ToInt32(Console.ReadLine());
            } while (guessNum != secNum);

            Console.WriteLine("The random number is {0}",secNum);

            //-------------------------------------------------------
            //-------------------------------------------------------

            Console.WriteLine("Enter number to divide:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("by:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                Console.WriteLine("{0} / {1} = {2}",num1,num2,Dziel(num1,num2));
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Do not divide by zero");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }catch(Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("This shows up even if an error occourred");
                Console.WriteLine("----------------------------------------");
            }






            Console.ReadLine();
        }

        static double Dziel(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}
