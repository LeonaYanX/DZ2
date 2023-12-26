//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
int intDigit = new Random().Next(10,100);
System.Console.WriteLine(intDigit);
int firstNum = intDigit/10;
int secondNum = intDigit%10;
if(firstNum > secondNum)
{
    System.Console.WriteLine($"from integer digits - {intDigit}- the bigger is {firstNum}");
}
else           //if firstNum == secondNum it also will be wrigth answer with else.
{
    System.Console.WriteLine($"from integer digits - {intDigit}- the bigger is {secondNum}");
}

