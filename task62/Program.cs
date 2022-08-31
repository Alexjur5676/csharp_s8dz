// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите колличество столбцов массива:"); 
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество строк массива:"); 
// int m = Convert.ToInt32(Console.ReadLine());
int m = 4;
int n = 4;
int s = 1;
int[,] matrix = new int[m, n];

for (int y = 0; y < n; y++)
{
    matrix[0, y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    matrix[x, n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--)
{
    matrix[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--)
{
    matrix[x, 0] = s;
     s++;
}
int c = 1;
int d = 1;
while (s < m * n)
{
    while (matrix[c, d + 1] == 0)
    {
        matrix[c, d] = s;
        s++;
        d++;
    }
    while (matrix[c + 1, d] == 0)
    {
        matrix[c, d] = s;
        s++;
        c++;
    }
    while (matrix[c, d - 1] == 0) 
    {
        matrix[c, d] = s;
        s++;
        d--;
    }
    while (matrix[c - 1, d] == 0) 
    {
        matrix[c, d] = s;
        s++;
        c--;
    }
}
    
for (int i = 0; i < matrix.GetLength(0); i++) 
{
        
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        if (matrix[i, j] == 0) 
        {
            matrix[i, j] = s;
        }
    }
}
 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            if (matrix[i, j] < 10)
            {
                Console.Write("0");
            }
            Console.Write(matrix[i, j]+ " ");
        }
        Console.WriteLine();
     }
}
PrintMatrix(matrix);
  