// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrixA(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrixA = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrixA;
}
void PrintMatrixA(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = FillMatrixA(2, 2);
Console.WriteLine("Первая матрица:");
PrintMatrixA(matrixA);

int[,] FillMatrixB(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrixB = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrixB;
}
void PrintMatrixB(int[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write(matrixB[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixB = FillMatrixB(2, 2);
Console.WriteLine("Вторая матрица:");
PrintMatrixB(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");

int[,] matrixC = new int[2,2];
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        matrixC[0,0] = matrixA[0,0] * matrixB[0,0] + matrixA[0,1] * matrixB[1,0];
        matrixC[0,1] = matrixA[0,0] * matrixB[0,1] + matrixA[0,1] * matrixB[1,1];
        matrixC[1,0] = matrixA[1,0] * matrixB[0,0] + matrixA[1,1] * matrixB[1,0];
        matrixC[1,1] = matrixA[1,0] * matrixB[0,1] + matrixA[1,1] * matrixB[1,1];
    }      
}
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {        
        Console.Write(matrixC[i, j] + " ");
    }    
    Console.WriteLine();
}

