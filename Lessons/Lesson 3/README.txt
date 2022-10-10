Lesson 3:

This lesson will go over the different types of loops and basic functions as well as the typical coding style in C#

Coding Style:
	Loop variables			- loop variables should start at i then j then k and so on.
	Variables			- C# uses camel case for variables. capitalize the start of each word except the first. ex. testVar, xDir, pointSystem, test
	Functions and classes		- Capital Each Word. ex. AddNumbers, TestingData
	immutable datatype		- Const or ReadOnly variables are all caps with _ between words. ex. MAX_HEIGHT, SPEED, MAX_TURN
	{}				- Like C you should put brackets on the line after the header. they shouldn’t go on the same line because it is harder to read
	ex of new line bracket (THIS IS TOTALLY NOT PERSONAL PREFERENCE AND SHOULD DEFINITLY BE TAKEN AS FACT):
		if(true)
		{
			do something 
		} 



	PROMPT ON LN 34



Loop types:
	While				//will run till the condition is false
	do while			//will run ONCE no matter what. then till the condition is false
	for				//will run a specific number of times, unless it is broken (loops can be exited with break whenever)
	foreach				//loops through each item of an enumerable(Lesson 4)

Function terms:
	return				//what the function spits out. its answer
	return type			//what kind of answer the function will spit out
	parameter			//what the function takes in
	default parameter		//optional parameter that has a default value
	visibility			//what files can see this function (not important till you have multiple files/classes)
	void				//a return type that means nothing.

Prompt:
	Create a menu-based application that contains the following functions:
	Calculator (turn lesson 1 into a function)
	Fibonacci calc (given an index output that many numbers of the Fibonacci sequence)
	Prime checker (tells if a number is prime or not)
	
	If you want to add more, you could add:
	Triangle solver (use MATH.tan, MATH.cos and so on)
	Tic Tac Toe (use Random to determine the bots move)

	This program should have a main menu it returns to after each function is performed.
	The program should have a way to exit when the user wants.







Hint (try without this):

	If you are struggling to create a main menu look at line 59 of program.cs and think back to lesson 1 to see what can be used to choose an output.
