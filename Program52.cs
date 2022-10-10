//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("введите количество строк m =");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов n =");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result = (result + numbers[i, j]);
    }
    result = result / m;
    Console.Write($"  {result = Math.Round(result,1)}  ");
}
Console.WriteLine();
void FillArrayRandomNumbers(int[,] array) //Заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)//Вывод массива на экран
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}