using System.Linq.Expressions;
Console.WriteLine("Welcome to Calculator ");
Console.WriteLine("Enter your operation( +, -, *. /): ");
string op = Console.ReadLine();
Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (op == "+")
    Console.WriteLine("The answer is: ", num1 + num2);
else if (op == "-")
    Console.WriteLine("The answer is: ", num1 - num2);
else if (op == "*")
    Console.WriteLine("The answer is: ", num1 * num2);
else if (op == "/")
    Console.WriteLine("The answer is: ", num1 / num2);
else Console.WriteLine("Invalid Command!");