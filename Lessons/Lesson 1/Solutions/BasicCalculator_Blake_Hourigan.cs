using System.Diagnostics.CodeAnalysis;

int num1= 0, num2 = 0, result, userChoice;

void printResult(int var)
{
    Console.Clear(); 
    Console.WriteLine("Your result is: " + var);
}

void printMenu()
{
    Console.Write("Please select an operation that you would like to perform from the menu:\n\n" +
      "1) Addition\n2) Subtraction\n3) Multiplication\n3) Division\n5) Modulus\n6) Exit\n\nYour choice: ");
    userChoice = Convert.ToInt16(Console.ReadLine());
}

void intakeNumbers()
{
    Console.WriteLine("Please input 2 numbers that you would like to perform an operation on.\n");

    Console.Write("Number 1: ");
    num1 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Number 2: ");
    num2 = Convert.ToInt16(Console.ReadLine());
}

while (true)
{ 
    printMenu();

    if (userChoice != 6)
    {
        intakeNumbers();
    }

    switch (userChoice)
    {
        case 1:
            result = num1 + num2;
            printResult(result);
            break;
        case 2:
            result = num1 - num2;
            printResult(result);
            break;
        case 3:
            result = num1 * num2;
            printResult(result);
            break;
        case 4:
            result = num1 / num2;
            printResult(result);
            break;
        case 5:
            result = num1 % num2;
            printResult(result);
            break;
        case 6:
            Environment.Exit(0);
            break;
    }
}