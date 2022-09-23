//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
int x = new Random().Next(100,999);
Console.WriteLine(x);
int temp = x/10;
int temp2 = temp%10;
Console.WriteLine(temp2);