// max & min из трёх чисел

Console.Clear();
Console.WriteLine("Введите число N1");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N2");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N3");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(N1>N2)
{
    max=N1;
   if(N1<N3)
   {
    max=N3;
   }
   else 
    max=N1;

}
else
{
    max=N2;
    min=N1;
}
while(N3>max)
{
   max=N3;
}

Console.WriteLine($"Максимальное число = {max}");