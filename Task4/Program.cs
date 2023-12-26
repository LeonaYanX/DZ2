// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
System.Console.WriteLine("Enter the number");
int N = Convert.ToInt32(Console.ReadLine());
int countOfNum = 0;
int baseN = N/10;
if(baseN==0)
{
countOfNum = 1;
Console.Write(N + ",");

}
else
{
    while(baseN!=0)
    {
        baseN = baseN/10;
        countOfNum = countOfNum +1;
    }
    


int[] numbersOfN = new int[countOfNum+1];
for(int i = countOfNum;i>=0 ; i-- )
{
numbersOfN[i] = N % 10;
N = N/10;
}
foreach(int e in numbersOfN)
{
    Console.Write(e +",");
}
}





