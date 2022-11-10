Lesson 4:

This lesson will cover enumerable and string manipulation to parse data. 

PROMPT ON LN 28

ALL INDEXING STARTS AT 0

Enumerable:
	Array		-A variable that can store a set amount of items
	List		-A dynamic array
	Stack		-A list that follows the last in first out principle
	Queue		-A list that follows the first in first out principle

String Commands:
	
	SubString	-takes in 2 ints, first int is the start index (string index at 0), second int is the length of the string you want
	Replace		-Takes 2 string, replace and string with another inside of a string. can be used to remove characters by replacing with ""
	Contains	-returns true if the string contains a specific string
	Split		-this creates an array of strings using whatever you input as the split value to split up your string
	Trim		-Removes and leading and trailing spaces
	ToUpper		-makes everything upper case
	ToLower		-Makes everything Lower case
	...			-there are more but these are the most useful



Prompt:
	in this lesson folder you will find a folder called "Prompt Files" and in there you will find a file called Data.nmea, the goal is to parse 2 types of lines from this, GNGGA and GNRMC. 
	These 2 lines give you the following information latitude, longitude, and time of a GPS. 
	parse ALL lines of those types and output it to a JSON file sorted by the time received (hint use the list.Sort function).

	you can see what values do what by using a decoder on this website

	$GNGGA,045524.000,3813.1379,N,08545.1941,W,1,13,0.80,167.0,M,-33.2,M,,*43
	$GNRMC,045524.000,A,3813.1379,N,08545.1941,W,0.64,111.62,201022,,,A * 60

	https://rl.se/gprmc

	one thing to note is the lat and lon are in DDMM.MMM format. to convert it to proper decimal do DD + MM.MMM/60

	TIME MUST BE IN HH:MM:SS when stored in string