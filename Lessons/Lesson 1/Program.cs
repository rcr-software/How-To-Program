/*Console.WriteLine("This is how you print to console");

Console.WriteLine("Please enter a number: ");
int x; //declares an uninitialized integer x

x = Console.Read(); //reads in an integer and stores it in x

Console.WriteLine(x); //outputs x

notice this does not output any character or the correct number that u put in

* Console.Read() gives you an int back no matter what u put in. so it converts all inputs to int
* it follows the Unicode standard. check out what values are here: https://www.ssec.wisc.edu/~tomw/java/unicode.html#x0000
 * to get it as a string we do this:



string y;

Console.WriteLine("Enter a string to echo: ");
y = Console.ReadLine();

Console.WriteLine(y);

 if the first time you entered a value it was more than one character this does not pause
 * Console.Read reads in EXACTLY 1 character, meaning all remaining remain on a buffer
 * to clear the buffer add a Console.ReadLine() after any Consle.Read()



Console.WriteLine("Please enter a number: ");
x = Console.Read(); //reads in an integer and stores it in x

Console.WriteLine(x);

Console.WriteLine("clearing buffer please wait a seconds and press enter if the next prompt does not appear");
Console.ReadLine(); //this line will clear buffer, but if there is no buffer the program will hang waiting for an input

Console.WriteLine("Enter a string to echo: ");
y = Console.ReadLine();

Console.WriteLine(y);

typically everything is read in with ReadLine so that you don’t worry about the buffer
* to read in an int we convert the string we get to an integer


Console.WriteLine("Enter an int to echo: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x);

// next is if. if statements will run only ONE line after them, however if that line is a { then it will go till it hits a }

if (x < 5)
    Console.WriteLine("you entered a value less than 5");
else if (x >= 10) //this will only run if ln 55 is false
{
    Console.WriteLine("you entered a value greater than 9"); // >= means 10 is included
    Console.WriteLine("please enter a new number");
    x = Convert.ToInt32(Console.ReadLine());
}
else //this will only run if line 55 and 57 are false
    Console.WriteLine("this number is fine");
Console.WriteLine("Your number is: " + x); //notice this line runs no matter what because it is outside of the if statement

// you can check both of these at the same time, or if either is acceptable then you can use or

if (x >= 10 && x < 5)
    Console.WriteLine("the value fits both parameters");
if (x >= 10 || x < 5) //note this will run even if the first is true because it is an if not an else if meaning it is NOT conditional on the previous if
    Console.WriteLine("the value fits at least one parameter");

neat thing c# does is auto convert variables when it thinks it should
 * these lines do not output the same thing



Console.WriteLine(x + " + 5 = " + x + 5); //this will add a 5 to the end of the text because it converts both things to strings
Console.WriteLine(x + " + 5 = " + (x + 5)); //this will add 5 to your inputted number because the parenthesis happen first
Console.Write(x + " + 5 = ");
Console.Write(x + 5 + "\n");

 as you go from left to right on ln 74 it goes
 *x + " + 5 = "
 * this is seen as a int plus a string
 * so c# says i will just convert string plus string to get string
 * then its " + 5 = " + x
 * which is the same thing so it adds the x again as a string
 * since x was converted to a string x +5 is seen as string plus int
 * which again gets converted to string plus string
 *
 * on ln 75 since you have() it sees x + 5 first
 * this is int + int so it actually adds them
 *
 *76 and 77 do the same as 75.on 76 I am using Console.Write()
 *this function does not move the cursor to the next line
 *on line 77 I add "\n" this will force the cursor to the next line
 *this can be done in the middle of a string to force it to the next line



Console.Write("This statement\nGoes across\nMany Lines\n");

//since the console is a bit cluttered we will clear it with this command but first we have to pause so you can read console
Console.WriteLine("Press any key to continue");
Console.ReadKey(); //this will wait for an input to continue. typically add these before a clear
Console.Clear();

Console.WriteLine("enter your first initial");

char z = Convert.ToChar(Console.Read());

switch (z)//switches need their own scope after them so you have to add {}
{
    case 'A': //this is the same as doing if(z == 'a')
        Console.WriteLine("your initial is an A");
        break; //this leaves the switch and will go to line 120
    case 'B':
    case 'C':
        Console.WriteLine("your initial is an B or C");
        goto default;//this goes to the default case so both line 115 and line 118 will run. you can also go to another case I.e. goto case 'a';
    default://this is essentially an else in the if statement
        Console.WriteLine("your initial is not A");
        break;
}

the last thing to mention is. if you did not enter a upper case initial that switch did not work.
 *most programs must be user proofed
 * to user proof this one.read it in or convert it to a string, then force it either upper case or lower case.



Console.WriteLine("Second switch:");

z = Convert.ToChar(z.ToString().ToUpper());

switch (z)
{
    case 'A':
        Console.WriteLine("your initial is an A");
        break;
    case 'B':
    case 'C':
        Console.WriteLine("your initial is an B or C");
        goto default;
    default:
        Console.WriteLine("The Unicode for you initial is: " + (int)z); //this will force case its from one datatype to another
        break;
}
*/