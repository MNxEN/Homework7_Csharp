// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int PromptInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}

int[,] GenerateArray2D()
{
    int rows = new Random().Next(3, 10);
    int columns = new Random().Next(3, 10);
    int[,] numbers = new int[rows, columns];
    Random rndVal = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rndVal.Next(-30, 51);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void FindAvg(int[,] numbers)
{

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }
        avg = Math.Round(sum / numbers.GetLength(0), 2);
        System.Console.WriteLine($"Среднее арифметическое столбца [{j}] = {avg}");
    }
}

int[,] array = GenerateArray2D();
PrintArray2D(array);
FindAvg(array);