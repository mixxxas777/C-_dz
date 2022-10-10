//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers [i]> 0)
    {
        result++;
    }
    else result = result+0;
}
Console.WriteLine($"Чисел больше 0 = {result}");
// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("введите числа = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}