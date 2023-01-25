void FillArray(double[,] matr)
{
    for (int rows=0; rows<matr.GetLength(0); rows++)
    {
        for(int columns =0; columns<matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().NextDouble() * new Random().Next(10, 1000);
        }
    Console.WriteLine();
    }
}

void PrintArray(double[,] matr)
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

double [,] arr = new double [3,4];

FillArray(arr);
PrintArray(arr);
