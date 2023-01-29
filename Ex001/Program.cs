// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[] arrayColection)
{
    int index = 0;
    Console.Write($"Числа массива: ");
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(100, 1000);

        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}

void PrintArray(int[] arrayColection)
{
    int index = 0;
    int amountEven = 0;
    int amountOdd = 0;
    while (index < arrayColection.Length)
    {
        if (arrayColection[index] % 2 == 0)
        {
            amountEven = amountEven + 1;
        }
        else
        {
            amountOdd = amountOdd + +1;
        }
        index++;
    }
    Console.WriteLine($"Количество чётных цифр в массиве: {amountEven}");
    Console.WriteLine($"Количество нечётных цифр в массиве: {amountOdd}");
}

Console.Write("Задайте размер массива : ");
int[] array = new int[int.Parse(Console.ReadLine() ?? "0")];
FillArray(array);
PrintArray(array);
