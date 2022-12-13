/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76

*/

// Генерирует массив случайных вещественных чисел
double[] InitArray(int dimension, int min, int max)
{
    double[] array = new double[dimension];
    Random rnd = new Random();
    double a;

    for (int i = 0; i < dimension; i ++)
    {
        a = rnd.NextDouble(); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        array[i] = Math.Round(rnd.Next(min, max) + a, 2); // Не прибавляем 1 к max, т.к. к нему прибавляется дробная часть
    }

    return array;
}

// Выводит массив в консоль
void PrintArray(string message, double[] array)
{
    Console.Write(message+": ");

    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i]+(i < array.Length - 1 ? ", " : ""));
    Console.Write("]");

    Console.WriteLine();
}

// Возвращает разницу между максимальным и минимальным элементом массива
double ArrayMaxMinDiff(double[] array)
{
    int minValueKey = 0;
    int maxValueKey = 0;

    for (var i = 0; i < array.Length; i ++)
    {
        if (array[i] < array[minValueKey])
            minValueKey = i;
        
        if (array[i] > array[maxValueKey])
            maxValueKey = i;
    }

    return array[maxValueKey] - array[minValueKey];
}

double[] array = InitArray(10, 0, 10);
PrintArray("Сгенерированный массив вещественных чисел", array);

Console.WriteLine("Разница между максимальным и минимальным элементом массива: "+ArrayMaxMinDiff(array));