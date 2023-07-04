// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1

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

void FindValue(int[,] numbers)
{
    int i = PromptInt("Введите номер строки");
    int j = PromptInt("Введите номер столбца");
    
    if (i < numbers.GetLength(0) && j < numbers.GetLength(1))
    {
       System.Console.WriteLine($"Значение ячейки [{i},{j}] равно '{numbers[i,j]}'");
    }
    else
    {
    System.Console.WriteLine($"Извините, ячейка [{i}, {j}] не существует");
    }
}

int[,] array = GenerateArray2D();
PrintArray2D(array);
FindValue(array);
