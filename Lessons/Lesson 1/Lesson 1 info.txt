This is lesson 1.

In this lesson you will learn how to create a console app and get started with the basics by making a simple calculator.

the goal with these is not to jump to far ahead. don’t create a program that is more advance or complicated than necessary. simplicity is key.
	skip to ln 56 for prompt.

you will learn about the following:

datatypes:
	int			// integers are whole numbers only. all numbers always round down
	double			// doubles are any numbers. if you want a non whole number usually use this
	float			// floats are the same as double but can only be half the size (we use these if we care about memory or don’t care about precision)
	bool			// Booleans stores true or false, also counts as 1 or 0
	char			// character is a single Unicode character (any symbol on the keyboard and some more)
	string			// string is usually read as an array or characters, i.e.. any sentence u can type

comparisons:
	==			// this is equal too. used for is A equal to B.(not = and == are not the same, = is for ASSIGNING a variable)
	!=			// ! means not, so != means not equal to
	> <			// greater than	and less than
	>= <=			// greater than or equal too and less than or equal too
	&&			// && means and, we use 2 because & is used for bitwise operation but that is not important now
	||			// || means or

operators:
	*			// multiply
	/			// divide
	+			// addition
	-			// subtraction
	%			// modulus. this is the remainder when dividing 2 ints. 2 % 5 = 2 because 2 is not divisible by 5. 5 % 2 = 1 because 5 / 2 = 2 remainder 1

Other:
	if()			// used to compare 2 things then run code if it is true
	else if()		// used to compare things and will only run code if the previous if is FALSE and this one is true
	else ()			// runs if all previous ifs are false
	switch()		// checks the given value with a list of provided possible values
	case:			// each accepted values of a switch
	default:		// the default result of a switch if the given value does not match a case
	break;			// leaves the current scope (ln 50). used to break out of switches and loops
	using			// lets you include a library (ln 52)
	Console			// class to interact with the console
	Convert			// Class to convert between different datatypes

other good to know terms (jargon):

Declaration			// making a variable. int x; this makes a integer with the name x
Assign				// set a variable with a single =. x = 5, x now stores the value 5
initialize			// this is used the first time you assign a variable. usually a variable is initialized when it is declared. int x = 5;
scope				// localized code. usually confined to a set of {}. something created in a scop can only see things in the same scope or in scopes nested further down
scope cont.			// for example a variable made in an if statement does not exist outside that if statement
Library				// code someone has made for people to use to perform a task easier

Most of the things listed above are shown off in the program.cs file. that file will compile and you can run it

Prompt:

Create a calculator that asks the user to input a number, the operation they would like to do and another number.
perform that operation and return it to the user.

The program should accept ALL 5 operations listed in the operators

The program.cs file should contain all relevant example code to make this program as well as other useful information

When you are finished feel free to view my solution in the solutions folder called solution.cs
