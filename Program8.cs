// На выходе все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число от 1 до N = ");
int N=Convert.ToInt32(Console.ReadLine());
int count=2;
int max=0;
int R=N%2;

if(R==0)
{
    max=N;
}
else
{
    max=N-1;
}
while(count<=N)
{
    Console.WriteLine(count);
    count+=2;
}