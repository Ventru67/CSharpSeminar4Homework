// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задайте длинну массива : ");
int Length = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[Length];
void FillArray(double[] arrayColection)
{
    int index = 0;
    Console.Write($"Числа массива: ");
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(1, 11);

        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}
void PrintArray(double[] arrayColection)
{
    int index = 0;
    double difference = 0;
    double max = 0;
    while (index < arrayColection.Length)
    {
        if (arrayColection[index] > max)
        {
            max = arrayColection[index];
        }
        index++;
    }
    Console.WriteLine($"MAX: {max}");
    double min = max;
    index = 0;
    while (index < arrayColection.Length)
    {
        if (arrayColection[index] < min)
        {
            min = arrayColection[index];
        }
        index++;
    }
    Console.WriteLine($"MIN: {min}");
    difference = max - min;
    Console.Write($"Разница между максимальным и минимальным числом: {difference}");
}
FillArray(array);
PrintArray(array);
