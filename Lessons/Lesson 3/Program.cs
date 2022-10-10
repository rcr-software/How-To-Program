//if you want to do something a specific number of times you use a for loop

int x = 5;

/*for loops have 4 parts. initialization (the starting state), condition (the condition for when to keep going),
 * increment (what to do to the loop variable after each iteration), and the code to run
 * 
 * for the loop variable you usually create it in the loop so it is destroyed when the loop is finished
 * on top of this the variable usually is i and if you have a nested loop it is j then k and so on.
 */

for (int i = 0; i < 2; i++)  //init int i at 0. check if i is less than 2. runs code. adds 1 to i
{
    x *= x; //putting the = after the operation makes it apply to itself.
    //this is equal to x = x * x
}

Console.WriteLine(x);

for (int i = x; i > 5; i--) //i can also be set to a variable if you want to start at the end of a list or something
{
    x -= 1; //this is the same as x--; or x = x-1;
}
//make sure to use -- instead of ++ since u need to count down

Console.WriteLine(x);

while (x < 100)//while loops run till condition is false
{
    x += 1;
}

Console.WriteLine(x);

char y;

do
{
    Console.WriteLine("Press x to Leave");
    y = Convert.ToChar(Console.ReadLine());

} while (y != 'x');

/*note y is not set to anything when the loop first runs. had this been a normal while loop it would error uncommenting the code below will show u
 * since this is a do while it will run first and during that first run y is initialized and can be used
 */

char z;

/*
while (z != 'x')
{
    Console.WriteLine("Press x to Leave");
    z = Convert.ToChar(Console.ReadLine);

}
*/

while (true) //the last thing with loops you can do is while(true) these loops will never stop and have to be broken out of
{
    Console.WriteLine("Press y to Leave and clear screen");
    z = Convert.ToChar(Console.ReadLine());

    if (z == 'y')
    {
        Console.Clear(); //clearing screen before i leave the loop
        break;
    }
}

//this loop has the same effect as the on ln 37 but is not a do while

//lastly are functions. all the code you write in this file is in a function. the function you are currently in is main

/*this is how you make a function
 * 
 * template:
 * return type
 * function name
 * parameter
 * 
 * Ex:
 * void
 * Output
 * (int x)
 */

//note int x is a different variable than the x declared on ln 3. this is because it is in a different scope
//much how like the variable i only exists inside the previous for loops and cant be used outside
void Output(int x)
{
    Console.WriteLine(x);
}

Output(3);

//note this return type is int. this function NEEDS to return an int. void does not need to return anything
int AddFive(int x)
{
    return x + 5;
}

Output(AddFive(3)); //nested function. first you add 5 to 3 then output that

bool HeadsOrTails()//you don’t need a parameter at all
{
    Random random = new Random(); //random library to make random numbers
    if (random.NextDouble() > .5) //NextDouble gives a number between 0 and 1. so if its greater than 5 its a heads
        return true;
    return false; //this doesn’t need an else because if its true then the function returns and this will never run
}

if (HeadsOrTails())
    Console.WriteLine("Heads");
else
    Console.WriteLine("Tails");

int AddNum(int x, int y = 1)//this function uses a default. if you don’t enter a second number it will default to 1
{
    return x + y;
}

Console.WriteLine(AddNum(3)); //returns 3+1
Console.WriteLine(AddNum(2, 2)); // returns 2+2

/*
 * there is also overloading which can have the same effect as using a default variable
 * overloading is when u have 2 functions with the same purpose but different parameters or return type
 * I would show this but it can not be done since this program is done inside main
 */

