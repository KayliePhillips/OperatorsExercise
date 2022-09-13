using OperatorExercise;
//Exercise 1
Console.WriteLine($"-----------Exercise 1------------------");

int a = 17;
int b = 4;

//Addition
//int c = a + b;
//Console.WriteLine(c);

//Subtraction
//int d = a - b;
//Console.WriteLine(d);

////Multiplication
//int e = a * b;
//Console.WriteLine(e);

//Division
int quotient = a / b;
Console.WriteLine(quotient);

//Modulus
int remainder = a % b;
Console.WriteLine(remainder);


if (a == 17 && b == 4)
{
    Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
    
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"-----------Exercise 2------------------");
Console.WriteLine();
Console.WriteLine();

Methods.AreaOfCircle();





Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"-----------Thought Exercise-------------------");
Console.WriteLine();
Console.WriteLine();

var i = 3;
var j = 4;
var k = ++i * j++;

Console.WriteLine(k);

//j++ doesn't change in value unless the equation is run more than one time.  Since this isn't a loop it is only 
//running one time.  So i increase by one to make 4 and 4*4 = 16.  Which is the answer when you run it.  If it were to run
//twice the answer would be 25.