int[] arr = new int[8];

//the array symbol is a square bracket []
//any data type can be made an array if you add it

//use the var name with the index to indicate which value you would like to access
arr[1] = 7;

Console.WriteLine(arr[1]);

//use arr.length to get the legnth of the array and loop through it
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

Console.WriteLine(arr[1]);

List<int> arr2 = new List<int>();
//similiar to an array a list can be made of any data type

for (int i = 0; i < arr.Length; i++)
{
    arr2.Add(i);//instead of having a predetermined storage size, you add items as neccesary
}
Console.WriteLine(arr2[1]); //you can still access these items like a normal array

Stack<int> arr3 = new Stack<int>();
for (int i = 0; i < arr.Length; i++)
{
    arr3.Push(i); //just like a list u add elements as u need them
}

//unlike a list you can ONLY see the last element added
Console.WriteLine(arr3.Peek());

//to remove that you pop it
arr3.Pop();

//you can also use it as you pop it to move on
Console.WriteLine(arr3.Pop());

//lastly you have a queue
Queue<int> arr4 = new Queue<int>();
for (int i = 0; i < arr.Length; i++)
{
    arr4.Enqueue(i); //same as list, add tihngs as u need
}

//just like a stack u can only look at 1 element however its the first instead of last
Console.WriteLine(arr4.Peek());

//to remove it you dequeue
arr4.Dequeue();

//and just like a stack u can remove and use it at the same time
Console.WriteLine(arr4.Dequeue());

//on to string parsing

string t = " temp string testing ";
t = t.Trim(); //trim removes spaces on the ends and is very nice
List<string> test = t.Split(' ').ToList(); //i prefer to work with lists so i split it to a list
foreach (string s in test)
    Console.WriteLine(s);

for(int i = 0; i < test.Count; i++)
{
    test[i] = test[i].Replace("t","z").ToUpper().Replace("z","x"); //one thing to note here is oprder of operations. the first replace happens
                                                                   //then it gets .toupper then the second replace doesnt do anything because it looks for a lower case z and there is none since it got ToUpper
}

foreach (string s in test)
    Console.WriteLine(s);

foreach (string s in test)
    if (s.Contains("G"))
        Console.WriteLine(s); //will only print out lines with a G in them