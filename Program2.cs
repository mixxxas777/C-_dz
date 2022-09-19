//max & min из двух чисел

Console.Clear();
Console.WriteLine("Введите число N1");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N2");
int N2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(N1>N2)
{
    max=N1;
    min=N2; 
}
else
{
    max=N2;
    min=N1;
}
Console.WriteLine($"Максимальное = {max}");
Console.WriteLine($"Минимальное = {min}");