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

void SearchPos(int[,] matr)
{
    Console.WriteLine("Теперь введите номер искомой строки: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Теперь введите номер искомого столбца: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = 0;
    int d = 0;
    for (int rows=0; rows<=matr.GetLength(0); rows++)
    {
        for(int columns=0; columns<=matr.GetLength(1); columns++)
        {
            if (a == rows && b == columns)
            {
                c = rows;
                d = columns;        
            }
        }
    }
    if (c>0 && d>0) Console.WriteLine($"Такое число в массиве есть, оно равно {matr[(c-1),(d-1)]}");
    else Console.WriteLine("Такого числа в заданом массиве нет");
}

int[,] arr = new int [4,4];

FillArray(arr);
PrintArray(arr);
SearchPos(arr);