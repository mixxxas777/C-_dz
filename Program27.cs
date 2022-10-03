// // Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(" число A = ");
int a = Convert.ToInt32(Console.ReadLine());
int S1 = 0;
int S = a; 
while (S > 0)
{    
     S1= S1+ S%10;
     S=S/10;
 } 
 Console.WriteLine($"{S1}");




