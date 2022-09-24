// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int k=N;
int z=0;
int i= 0;
if (N>=10000&&N<=99999)
{
 for(i=0;i<5;i++)
 {
  z=z*10+(k%10);
  k=k/10;
 }
  if (z==N)Console.WriteLine("ДА");
  else Console.WriteLine("НЕТ");
}
else Console.WriteLine("Вы ввели не верное число");