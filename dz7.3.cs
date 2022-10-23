/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
int[,] generate2DArray (int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd);
        }
    }
    return twoDArray;
}

void print2DArray (int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void sum2DArray (int[,] arrayToSum)
{
    double[] sumArray = new double[arrayToSum.GetLength(1)];
    int count = 0;
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
    for (int i = 0; i < arrayToSum.GetLength(1); i++)
    {
        for (int j = 0; j < arrayToSum.GetLength(0); j++)
        {
            sumArray[i] = sumArray[i] + arrayToSum[j,i];
            count ++;
        }
        sumArray[i] = sumArray[i] / count;
        count = 0;
    }
    for (int q = 0; q < sumArray.Length; q++)
        {
            Console.Write(sumArray[q] + "\t");
        }
        Console.WriteLine();
}

Console.WriteLine("введите количество строк: ");
int widthUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int heightUser = Convert.ToInt32(Console.ReadLine());
int[,] generatedArray = generate2DArray(widthUser, heightUser, 1, 100);
print2DArray(generatedArray);
sum2DArray(generatedArray);