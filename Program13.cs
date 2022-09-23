// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число N =");
int N = Convert.ToInt32(Console.ReadLine());
int N3 =0;
int i = 100;
 if (N<i)
{
Console.WriteLine("третьей цифры нет");
}
else 
{
N3=(N/100)%10;
}
 Console.WriteLine(N3);
 
 