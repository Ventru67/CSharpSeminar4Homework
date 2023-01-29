// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задайте длинну массива : ");
int Length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[Length];
void FillArray(int[] arrayColection)
{
    int index = 0;
    Console.Write($"Числа массива: ");
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(1, 10);

        Console.Write($" {arrayColection[index]}");
        index++;
    }
    Console.WriteLine();
}
void PrintArray(int[] arrayColection)
{
    int index = 1;
    int sum = 0;
    while (index < arrayColection.Length)
    {
        sum = sum + arrayColection[index];
        index = index + 2;
    }
    Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции = {sum}");
}
FillArray(array);
PrintArray(array);
