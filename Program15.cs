// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.Write("Введите число от 1 до 7, соответствующее дню недели N= ");
int N = Convert.ToInt32(Console.ReadLine());
if(N<1||N>7)
{
 Console.WriteLine("Вы ввели не верное число");
}
if(N<6&&N>0)
{
    Console.WriteLine("НЕТ");
}
 else if(N>5&&N<8)
{
    Console.WriteLine("ДА");
}
