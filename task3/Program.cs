void PrintArray(int[,] matr)
{
    for (int rows=0; rows<matr.GetLength(0); rows++)
    {
        for(int columns =0; columns<matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows=0; rows<matr.GetLength(0); rows++)
    {
        for(int columns =0; columns<matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1,10);
        }
    Console.WriteLine();
    }
}

void Average(int[,] matr)
{
    int rows = matr.GetLength(0);
    int columns = matr.GetLength(1);

    for  (int x = 0; x < columns; x++)
    {
        float rowsAvg = 0;
        for (int i = 0; i < rows; i++)
        {
            rowsAvg+=matr[i,x];
        }
        rowsAvg = rowsAvg / rows;
        Console.WriteLine($"Среднее арифметическое столбца {x+1} - {rowsAvg} ");        
    }
}

int[,] arr = new int [3,4];

FillArray(arr);
PrintArray(arr);
Average(arr);

