/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/


// Генерирует массив случайных чисел
// numDigitsInEachValue - количество знаков в числе
int[] InitArray(int dimension, int numDigitsInEachValue = 1)
{
    // Вычисляем минимальное и максимальное значение массива исходя из заданного количества знаков в числе
    int min = 0;
    int max = 9;

    if (numDigitsInEachValue > 1)
    {
        min = 1;
        for (int i = 1; i < numDigitsInEachValue; i ++)
            min *= 10;
        max = min * 10 - 1;
    }

    // Составляем массив
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i ++)
        array[i] = rnd.Next(min, max + 1);

    return array;
}

// Выводит массив в консоль
void PrintArray(string message, int[] array)
{
    Console.Write(message+": ");

    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i]+(i < array.Length - 1 ? ", " : ""));
    Console.Write("]");

    Console.WriteLine();
}

// Возвращает количество чётных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (var i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0)
            count ++;
    }

    return count;
}

int[] array = InitArray(6, 3);
PrintArray("Сгенерированный массив", array);

Console.WriteLine("Количество чётных чисел в массиве: "+CountEvenNumbers(array));