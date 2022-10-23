/* 
Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void search2DArray (int[,] arrayToSearch, int searchNumber)
{
    int[] searchArray = new int[arrayToSearch.GetLength(0) * arrayToSearch.GetLength(1)];
    int count = 0;
    if (searchNumber < searchArray.Length)
    {
        for (int i = 0; i < arrayToSearch.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToSearch.GetLength(1); j++)
            {
                searchArray[count] = arrayToSearch[i,j];
                count ++;
            }
        }
        Console.WriteLine($" Искомое число: {searchArray[searchNumber]}");
    }
    else Console.WriteLine($"{searchNumber} -> такого числа в массиве нет");    
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
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позицию элемента: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[,] generatedArray = generate2DArray(5, 6, -10, 10);
print2DArray(generatedArray);
search2DArray (generatedArray, userNumber);