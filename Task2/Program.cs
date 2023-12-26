//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.
double[] coordinates = new double[2];
System.Console.WriteLine("Enter the x coordinate for this dot");
coordinates[0] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter the y coordinate for this dot");
coordinates[1] = Convert.ToDouble(Console.ReadLine());
for(int i =0 ; i< coordinates.Length ; i++)
{
    if(coordinates[i]==0)
    {
        System.Console.WriteLine("You cannot enter 0 , reenter please");
        coordinates[i] = Convert.ToDouble(Console.ReadLine());
    }
   

}
if(coordinates[0]>0 && coordinates[1]>0)
{
    System.Console.WriteLine("number of the coordinate quarter of the plane is 1");
}
 if(coordinates[0]>0 && coordinates[1]<0)
{
    System.Console.WriteLine("number of the coordinate quarter of the plane is 4");
}
if(coordinates[0]<0 && coordinates[1]>0)
{
    System.Console.WriteLine("number of the coordinate quarter of the plane is 2");
}
if(coordinates[0]<0 && coordinates[1]<0)
{
    System.Console.WriteLine("number of the coordinate quarter of the plane is 3");
}


