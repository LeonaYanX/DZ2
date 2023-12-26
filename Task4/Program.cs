// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
System.Console.WriteLine("Enter the number");
int N = Convert.ToInt32(Console.ReadLine());
int countOfNum = 0;
long baseN = N/10;
if(baseN==0)
{
countOfNum = 1;

}
else
{
    while(baseN!=0)
    {
        baseN = baseN/10;
        countOfNum = countOfNum +1;
    }
    
}

int[] numbersOfN = new int[countOfNum+1];
for(int i = 0;i<=countOfNum ; i++ )
{
numbersOfN[i] = N % 10;
N = N/10;
Console.Write(numbersOfN[i] +",");
}





