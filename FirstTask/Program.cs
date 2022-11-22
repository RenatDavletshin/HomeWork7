// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}