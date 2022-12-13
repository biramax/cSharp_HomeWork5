/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

// Генерирует массив случайных чисел
int[] InitArray(int dimension, int min, int max)
{
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

// Возвращает сумму элементов, стоящих на нечётных позициях
int SumOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i ++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }

    return sum;
}

int[] array = InitArray(5, -10, 10);
PrintArray("Сгенерированный массив", array);

Console.WriteLine("Количество чётных чисел в массиве: "+SumOddNumbers(array));