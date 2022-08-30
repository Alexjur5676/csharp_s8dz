// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] FillMatrix(int rowsCount, int columnsCount, int boundCount, int leftRange = 10, int rightRange = 100)
{   
    int[,,] matrix = new int[rowsCount, columnsCount, boundCount ];
    int[] numbers = new int[2*2*2];
    Random random = new Random(); 
    int numbersGenerated = 0;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                int number = random.Next(10, 100);
                bool generated = false;
                while (!generated)
                {
                   
                    generated = true;
                    for (int l = 0; l < numbersGenerated; l++)
                    {
                        if (numbers[l] == number)
                        { 
                            generated = false;
                            break;
                        }
                    }    
                    if (!generated)
                    {
                        number = random.Next(10, 100);
                    } 
                    else 
                    {
                        numbersGenerated++;
                    }
                                        
                }
                matrix[i,j,k] = number;
            }
        }    
    }
    return matrix;   
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                
                Console.Write(matrix[i, j, k] + "");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = FillMatrix(2, 2, 2);
Console.WriteLine("Трехмерный массив:");
PrintMatrix(matrix);


// int[,,] FillMatrix(int rowsCount, int columnsCount, int boundCount, int leftRange = 10, int rightRange = 100)
// {   
//     int[,,] matrix = new int[rowsCount, columnsCount, boundCount ];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            for (int k = 0; k < matrix.GetLength(1); k++)
//            {
//                  matrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
//            } 
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < 2; i++)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             for (int k = 0; k < 2; k++)
//             {
                
//                 Console.Write(matrix[i, j, k] + "");
//                 Console.Write($"({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] matrix = FillMatrix(2, 2, 2);
// Console.WriteLine("Трехмерный массив:");
// PrintMatrix(matrix);


