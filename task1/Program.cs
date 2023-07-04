// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

double PromptDouble(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    double value;
    if (double.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является числом");
    Environment.Exit(0);
    return 0;
}


double[,] GenerateArray2D(int rows, int columns, double min, double max)
{
    double[,] numbers = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(rnd.NextDouble() * ((max) - (min)) + (min), 2);
        }
    }
    return numbers;
}
void PrintArray2D(double[,] numbers)
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

int nRow = PromptInt("Введите количство строк");
int nCol = PromptInt("Введите количство столбцов");
double min  = PromptDouble("Введите минимальное значение");
double max  = PromptDouble("Введите максимальное значение");
double[,] Array = GenerateArray2D(nRow,nCol,min,max);
PrintArray2D(Array);


