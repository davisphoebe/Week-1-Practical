
//task 1 - processing user input
Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

Console.WriteLine("Hi, " + name + ". Please enter your age ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the age you wish to find the difference from ");
int targetAge = Convert.ToInt32(Console.ReadLine());
if (age < targetAge)
{ 
int yearsUntilTarget = targetAge - age;
Console.WriteLine("You have " + yearsUntilTarget + " years until you reach " + targetAge);
 }
else if (age > targetAge)
{
    int yearsFromTarget = age - targetAge;
    Console.WriteLine("You are " + yearsFromTarget + " years older than " + targetAge);
}
else
{
    Console.WriteLine("This is your age");
}
Console.WriteLine();



//task 2 - selection statements
if (age < 13)
{
    Console.WriteLine("you are a child");
}
else if (age >= 13 && age <=19)
{
    Console.WriteLine("you are a teenager");
}
else if (age > 19 && age <= 110)
{
    Console.WriteLine("you are an adult");
}
else
{
    Console.WriteLine("You are out of the age range");
}
Console.WriteLine();




//task 3 - logical operators
Console.WriteLine("Please enter an integer");
int i = Convert.ToInt32(Console.ReadLine());
if (i == 0)
{
    Console.WriteLine("This number is zero");
}
else if (i > 0)
{
    Console.WriteLine("This is a positive number");
}
else
{
    Console.WriteLine("This is a negative number");
}
Console.WriteLine();





//task 4 - Leap Year Checker
Console.WriteLine("Please enter a year to check if it is a leap year");
int year = Convert.ToInt32(Console.ReadLine());
int r = year % 4;
if (year < 0)
{
    Console.WriteLine("This is not a valid year");
}
else if (r == 0)
{
    Console.WriteLine(year + " is a leap year");
}
else
{
    Console.WriteLine(year + " is not a leap year");
}
Console.WriteLine();







//task 5 - even or odd checker
Console.WriteLine("Please enter an integer to check for even and odd");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 2;
if (r == 0)
{
    Console.WriteLine("This is an even number");
}
else
{
    Console.WriteLine("This is an odd number");
}
