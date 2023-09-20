using System;

class allCalculatorMethods
{
    // Method for addition
    public void Addition()
    {
        Console.WriteLine("Enter how many numbers you want to add: ");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            int[] arr = new int[count];
            Console.WriteLine("Now enter numbers:");
            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    arr[i] = num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return; // Exit the method if invalid input is detected.
                }
            }

            int result = 0;
            for (int i = 0; i < count; i++)
            {
                result += arr[i];
            }
            Console.WriteLine("Result after addition = " + result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid count.");
        }
    }

    // Method for multiplication
    public void Multiplication()
    {
        Console.WriteLine("Enter how many numbers you want to multiply: ");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            int[] arr = new int[count];
            Console.WriteLine("Now enter numbers:");
            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    arr[i] = num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return; // Exit the method if invalid input is detected.
                }
            }

            int result = 1;
            for (int i = 0; i < count; i++)
            {
                result *= arr[i];
            }
            Console.WriteLine("Result after multiplication = " + result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid count.");
        }
    }

    // Method for division
    public void Division()
    {
        Console.WriteLine("Enter the numerator: ");
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Enter the denominator: ");
            if (int.TryParse(Console.ReadLine(), out int b))
            {
                if (b != 0)
                {
                    int result = a / b;
                    Console.WriteLine("Result of division = " + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for denominator. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for numerator. Please enter a valid number.");
        }
    }

    // Method for subtraction
    public void Substarction()
    {
        Console.WriteLine("\nEnter how many numbers you want Subtraction = ");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[count];
        Console.WriteLine("\nNow Enter numbers:");
        for (int i = 0; i < count; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = 0;
        for (int i = 0; i < count; i++)
        {
            result -= arr[i];
        }
        Console.WriteLine("Here is the Result after Subtraction = " + result);
    }

    // Method for modulo
    public void Modulo()
    {
        Console.WriteLine("\nEnter Two Numbers for Modulo:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = a % b;
        Console.WriteLine("Here is the Result Modulo = " + result);
    }

    // Method for power
    public void Power()
    {
        Console.WriteLine("\nEnter Two Numbers for Power:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(a, b);
        Console.WriteLine("Here is the Result Power = " + result);
    }
}

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n-------This is a Calculator Application!-------");
                Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulo\n6.Power\n7.Exit!");
                Console.WriteLine("Enter your choice from above Options:");
                choice = Convert.ToInt32(Console.ReadLine());
                allCalculatorMethods calc = new allCalculatorMethods();
                switch (choice)
                {
                    case 1:
                        calc.Addition();
                        break;

                    case 2:
                        calc.Substarction();
                        break;

                    case 3:
                        calc.Multiplication();
                        break;

                    case 4:
                        calc.Division();
                        break;

                    case 5:
                        calc.Modulo();
                        break;

                    case 6:
                        calc.Power();
                        break;

                    case 7:
                        Console.WriteLine("Exiting from the Calc Application!");
                        break;

                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;
                }
            } while (choice != 7);
        }
    }
}
