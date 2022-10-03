// //  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int [] array;
array = new int[8];
Console.WriteLine("введите число 1= ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2= ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 3= ");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 4= ");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 5= ");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 6= ");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 7= ");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 8= ");
array[7] = Convert.ToInt32(Console.ReadLine());
var str = string.Join(",",array);
{
   Console.Write($"[{str}]");            
}