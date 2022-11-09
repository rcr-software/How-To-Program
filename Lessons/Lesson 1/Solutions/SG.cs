
int x;
char sign;
int y;

Console.Write("What is the first number?");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the operator:");
sign = Convert.ToChar(Console.ReadLine());
Console.Write("What is the last number?");
y = Convert.ToInt32(Console.ReadLine());

if (sign == '+')
    Console.WriteLine(x + y);
else if (sign == '-')
    Console.WriteLine(x - y);
else if (sign == '*')
    Console.WriteLine(x * y);
else if (sign == '/')
    Console.WriteLine(x / y);
else if (sign == '%')
    Console.WriteLine(x % y);

