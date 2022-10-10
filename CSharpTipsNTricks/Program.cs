/*
 
   Tip: 1  Improve Code Readbility With OR Operator
 
 */

int a = 0;

if (a is 1 or 2)
    Console.WriteLine("The assigned value is not  1 or 2");
else
    Console.WriteLine("The assigned value is 0");

/*
    Tip:2 Improve Code Readbiltiy with AND Operator
    
 */

int b = 10;

if (b is >= 10 and <= 15)
    Console.WriteLine("Between 10 and 15");
else
    Console.WriteLine("Not Between 10 and 15");

