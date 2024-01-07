/*
 Övning 4: Ett kafé utlyser en kampanj där personer äldre än 65 år samt personer mellan 10 och
18 erbjuds att köpa kaffe till ett extra billigt pris. Skriv ett program som innehåller endast 
en ifsats som undersöker om användaren kan få köpa kaffe extra billigt.
 */

namespace ifStatementsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Extra price! Are you between 10-18 or above 65? Then you will get half price on coffee!!");
                Console.WriteLine("Enter your age:");
                if(int.TryParse(Console.ReadLine(), out int age)) 
                {
                    if (age > 64 || age > 9 && age < 19)
                    {
                        Console.WriteLine("You will get the extra price for coffee! Congratulations");
                        break;
                    }
                    else { Console.WriteLine("You get to pay full price! Sorry..."); break; }
                }
                else { Console.WriteLine("Enter a number!"); continue; }
            }
        }
    }
}
