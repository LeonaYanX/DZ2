// Task 1 
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
System.Console.WriteLine("Enter the value");
int value = Convert.ToInt32(Console.ReadLine());
if(value%7==0 && value%23 == 0 )
{
    if(value != 0)
    {
    System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("NONONO it's zero");
    }
}
else
{
System.Console.WriteLine("No");
}
