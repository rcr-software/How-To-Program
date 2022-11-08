Console.WriteLine("Welcome to my calculator! \nI will ask for two numbers and then ask for the operation you would like to do.");

Console.Write("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Select an operation \nInput one of the following: '+,-,*,/,%'");
char operation = Convert.ToChar(Console.ReadLine());

//Switch below reads previous operation request and preforms one of five operations on the numbers. Default is modulus function
switch (operation)
{
    case '+':
        Console.Write($"{number1}{operation}{number2} = ");
        Console.Write(number1 + number2);
        break;
    case '-':
        Console.Write($"{number1}{operation}{number2} = ");
        Console.Write(number1 - number2);
        break;
    case '*':
        Console.Write($"{number1}{operation}{number2} = ");
        Console.Write(number1 * number2);
        break;
    case '/':
        Console.Write($"{number1}{operation}{number2} = ");
        Console.Write(number1 / number2);
        break;        
    default:
        Console.Write($"{number1}%{number2} = ");
        Console.Write(number1 % number2);
        break;
}
