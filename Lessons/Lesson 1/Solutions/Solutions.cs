Console.Write("Please enter you first number: "); //I used write instead of writeline because i like my input being on same lane as text
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("\nPlease enter the operator: ");
char z = Convert.ToChar(Console.ReadLine());

Console.Write("\nPlease enter you second number: ");
double y = Convert.ToDouble(Console.ReadLine());

if (z == '%') //modulus only works with ints so its special
{
    x = (int)(x + .5); //rounding on my cast
    y = (int)(y + .5);
}

Console.Write("\n" + x + " " + z + " " + y + " = ");

switch (z)
{
    case '+':
        Console.Write(x+y);
        break;
    case '-':
        Console.Write(x-y);
        break;
    case '/':
        Console.Write(x/y);
        break;
    case '*':
        Console.Write(x*y);
        break;
    case '%':
        Console.Write(x%y);
        break;
    default:
        Console.Write("INVALID OPERATION");
        break;
}