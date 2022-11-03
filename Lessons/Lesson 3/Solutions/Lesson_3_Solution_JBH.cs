using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

double num1 = 0, num2 = 0;  // gloabl variables for basic calculator portion.
int index = 0, userChoice; // global variables for fibbonacci function.

void PrintResult(double varToPrint)
{
    Console.Clear();
    Console.WriteLine("Your result is: " + varToPrint);
}

void PrintMenu()
{
    Console.Write("Please select an operation that you would like to perform from the menu:\n\n" +
      "1) Addition\n2) Subtraction\n3) Multiplication\n3) Division\n5) Modulus\n6) FibSequence\n7) Prime # Checker\n" +
      "8) Exit\n\nYour choice: ");
    userChoice = Convert.ToInt16(Console.ReadLine());
}

void IntakeNumbers(int choice) // intakes userchoice variable to determine which portion of IntakeNumbers to use
{
    if (choice <= 5)
    {
        Console.WriteLine("Please input 2 numbers that you would like to perform an operation on.\n");

        Console.Write("Number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
    else if(choice == 6)
    {
        Console.WriteLine("Please enter the index you'd like to find the fib value up to: ");
        index = (Convert.ToInt16(Console.ReadLine())) - 1; Console.Clear();
    }
    else if(choice == 7)
    {
        Console.WriteLine("Please enter the number that you would like to check primality of: ");
        num1 = Convert.ToDouble(Console.ReadLine());
    }

}

void FibSequence() 
{
    int a = 0, b = 1, temp = 0;  // defines index to find value up to and first, second and
                                // temporary value for calculating the sequence
    IntakeNumbers(userChoice);
    
    Console.WriteLine("The fib sequence up to that index is: \n");
    for (int i = 0; i <= index; i++)
    {
        Console.Write(temp + ",");
        temp = a + b;
        a = b;
        b = temp; 
    }

    Console.WriteLine("\n");
}

void PrimeNumberChecker()
{
    IntakeNumbers(userChoice);

    if (num1 > 1)
    {
        for (int i = 2; i < Math.Sqrt(num1); i++)
        {
            if (num1 % i == 0)
            {
                Console.WriteLine("not prime");
                break;
            }
            else if (i == (Math.Sqrt(num1) -1))
            {
                Console.WriteLine("prime");

            }
        }
    }
    else if (num1 == 0)
    {
        Console.WriteLine("not prime");
    }


}

while (true)
{ 
    PrintMenu();

    switch (userChoice)
    {
        case 1:
            IntakeNumbers(userChoice);
            PrintResult(num1 + num2);
            break;
        case 2:
            IntakeNumbers(userChoice);
            PrintResult(num1 - num2);
            break;
        case 3:
            IntakeNumbers(userChoice);
            PrintResult(num1 * num2);
            break;
        case 4:
            IntakeNumbers(userChoice);
            PrintResult(num1 / num2);
            break;
        case 5:
            IntakeNumbers(userChoice);
            PrintResult(num1 % num2);
            break;
        case 6:
            FibSequence();
            break;
        case 7:
            PrimeNumberChecker();
            break;
        case 8:
            Environment.Exit(0);
            break;

    }
}
