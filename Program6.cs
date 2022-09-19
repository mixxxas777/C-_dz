// Является ли число на входе четным?
Console.Clear();
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int R = N%2;
if(R==0)
{
    Console.WriteLine($"Число {N} - чётное");
}
else
{
    Console.WriteLine($"Число {N} - НЕ чётное");
}