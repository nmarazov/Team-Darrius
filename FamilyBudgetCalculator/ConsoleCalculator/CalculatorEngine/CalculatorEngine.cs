using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class CalculatorEngine
    {
        private const string NotAValidNumberMessage = "Not a valid number";
        private const string NotAValidChoiceMessage = "Not a valid choice";
        private const string NotANumberMessage = "Not a number";


        public static void MenuChoiceVerification(int choice, int limit)
        {
            if (choice > limit || choice <= 0)
            {
                throw new ArgumentOutOfRangeException(NotAValidChoiceMessage);
            }
        }

        public static int Menu(string[] items)
        {
            int result = 0;
            bool ChoiceNotValid = true;
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, items[i]);
                Console.WriteLine();

            }
            Console.Write("Please give your choice:");
            while (ChoiceNotValid)
            {
                try
                {
                    result = int.Parse(Console.ReadLine());
                    MenuChoiceVerification(result, items.Length);
                    ChoiceNotValid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine(NotANumberMessage);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(NotAValidNumberMessage);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine(NotAValidChoiceMessage);
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
                Console.WriteLine("New Budget");
                // TODO: Input of new budget
            }
            else if (mainChoice == 2)
            {
                Console.WriteLine("Budget from file");
                // TODO: Read from file
            }
            else
                Console.WriteLine("Thank you for using this program");
        }
    }
}
