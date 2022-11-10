// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choose Operation: \n 0.addition \n 1. Subtraction \n 2. Multiply \n 3. Divide \n 4.Module ");

int selection = Convert.ToInt32(Console.ReadLine());
int result;

Console.WriteLine("Enter first number/den: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number/num: ");
int b = Convert.ToInt32(Console.ReadLine());

switch (selection)
{
    case 0: //add
        result = (a + b);
        Console.WriteLine(result);
        break;
    case 1:
        result = (a - b);
        Console.WriteLine(result);
        break;
    case 2:
        result = (a * b);
        Console.WriteLine(result);
        break;
    case 3:
        result = (a / b);
        Console.WriteLine(result);
        break;
    case 4:
        result = (a % b);
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("Invaid");
        break;


}