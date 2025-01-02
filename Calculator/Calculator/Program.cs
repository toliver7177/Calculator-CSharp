using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation;
            int solution;

            //Opening Statement
            Console.WriteLine("Hello! Welcome to the caluclator program!");
            Console.WriteLine("What operation will you be doing today?");
            Console.WriteLine("Select 'A' for addition, 'S' for subtraction, 'M' for multiplication, or 'D' for division");

            operation = Console.ReadLine();
            operation = operation.ToUpper();
            
            while(operation != "A" && operation != "S" && operation != "M" && operation != "D")
            {
                Console.WriteLine("Invalid selection. Please try again");
                operation = Console.ReadLine();
                operation = operation.ToUpper();
            }
            

            Console.WriteLine("Please enter your first number:");
            
            //Stores the first number
            num1 = Convert.ToInt32(Console.ReadLine()); //account for invalid value

            Console.WriteLine("Please enter your second number:");

            //Stores the second number
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "A":
                    solution = num1 + num2;
                    Console.WriteLine("The solution to " + num1 + " + " + num2 + " is: " + solution);
                    break;
                case "S":
                    solution = num1 - num2;
                    Console.WriteLine("The solution to " + num1 + " - " + num2 + " is: " + solution);
                    break;
                case "M":
                    solution = num1 * num2;
                    Console.WriteLine("The solution to " + num1 + " * " + num2 + " is: " + solution);
                    break;
                case "D":
                    solution = num1 / num2;
                    Console.WriteLine("The solution to " + num1 + " / " + num2 + " is: " + solution);
                    break;
            }
            

            //Make program wait for user input to close console window
            Console.ReadKey();
        }
    }
}
