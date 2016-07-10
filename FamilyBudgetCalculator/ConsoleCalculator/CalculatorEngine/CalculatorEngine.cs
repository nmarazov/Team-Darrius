using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class CalculatorEngine
    {
        public static void MenuChoiceVerification(int choice, int limit)
        {
            if (choice > limit||choice <=0)
            {
                throw new ArgumentOutOfRangeException("Not a valid choice");
            }
        } 

        public static int Menu(string[] items)
        {
            int result = 0;
            bool ChoiceNotValid = true;
            for( int i=0; i<items.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, items[i]);
                Console.WriteLine();

            }
            while (ChoiceNotValid)
            {
                try
                {
                    Console.Write("Please give your choice:");
                    result = int.Parse(Console.ReadLine());
                    MenuChoiceVerification(result, items.Length);
                    ChoiceNotValid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Not a valid number");
                }
                finally
                {
                    Console.WriteLine("This program sucks");
                }
            }
            return result;
        }

        public static void StartPage()
        {
            string[] mainMenu = new string[3]{
                "Input of new budget",
                "File input",
                "Exit"
                };

            int mainChoice = Menu(mainMenu);
            if (mainChoice == 1)
            {
                // TODO: Input of new budget
            }
            else if (mainChoice == 2)
            {
                // TODO: Read from file
            }
            else
                Console.WriteLine("Thank you for using this program");
        }
    }
}
