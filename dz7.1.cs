// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] generate2DArray (int height, int width, int randomStart, int randomEnd)
{
    double[,] twoDArray = new double[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd);
        }
    }
    return twoDArray;
}
void print2DArray (double[,] arrayToPrint)
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
Console.WriteLine("Введите число m: ");
int widthM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int heightN = Convert.ToInt32(Console.ReadLine());
double[,] generatedArray = generate2DArray(heightN, widthM, -10, 10);
print2DArray(generatedArray);