

using System.Runtime.InteropServices;

Console.WriteLine("Please enter a number: ");
double x; //declalres an unitialized integer x
char op;
double y; 
x = Convert.ToDouble(Console.ReadLine()); //reads in an integer and stores it in x
op = Convert.ToChar(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
switch(op)
{
    case '%': 
            Console.WriteLine(x + " % " + y + " = " + (x%y));
        break;
    case '*':
            Console.WriteLine(x + " * " + y + " = " + (x*y));
        break;
    case '/':
            Console.WriteLine(x + " / " + y + " = " + (x/y));
        break;
    case '-':
            Console.WriteLine(x + " - " + y + " = " + (x-y));
        break;
    case '+':
            Console.WriteLine(x + " + " + y + " = " + (x+y));
        break;
}



Console.WriteLine(x); //outputs x