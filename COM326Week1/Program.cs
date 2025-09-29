
//task 1
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




//task 2
if (age < 13)
{
    Console.WriteLine("you are a child");
}
else if (age >= 13 | age <=19)
{
    Console.WriteLine("you are a teenager");
}
else if (age > 19 | age <= 110)
{
    Console.WriteLine("you are an adult");
}
else
{
    Console.WriteLine("You are out of the age range");
}


