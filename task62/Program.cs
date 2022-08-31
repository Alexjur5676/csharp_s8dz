// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// static void Main()
// {
//     int n;
//     Console.WriteLine("Введите размерность массива");
//     n = Convert.ToInt32(Console.ReadLine());
//     var a = GetSpire(n);
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(a[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

        
// private static int[,] GetSpire(int n)
// {
//     int[,] GetSpire(int n);
        
//     var result = new int[n, n];
//     Random rand = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = rand.Next(n, n);
//         }
//     }
//     for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
//     {
//         for (int j = padding; j < n - padding; j++)
//         {
//             result[padding, j] = currentChar;
//         }    
//         for (int j = padding; j < n - padding; j++)
//         {
//             result[n - padding - 1, j] = currentChar;
//         }   
//         for (int i = padding + 2; i < n - padding - 1; i++)
//         {
//             result[i, padding] = currentChar;
//         }   
//         for (int i = padding + 1; i < n - padding - 1; i++)
//         {
//             result[i, n - padding - 1] = currentChar;
//         }   
//         currentChar = 1 - currentChar;
//         result[padding + 1, padding] = currentChar;
//     }
//     if (n % 2 != 0 && result[0, 0] == 1)
//     {
//         result[n / 2, n / 2] = 1;
//     }  
//     return result;
// }



// static void main(String[] args)
// {
        //Заполним массив, количество строк мы обозначим m, а столбцов - n.
    int m = 5;
    int n = 5;
 
        //С помощью переменной s задаются числа внутри массива начиная с 1.
    int s = 1;
 
        //Объявляем и инициализируем массив.
    int[,,] array = new int[m, n];
 
        //Заполняем периметр массива по часовой стрелке.
    for (int y = 0; y < n; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = s;
            s++;
    }
 
        //Периметр заполнен. Продолжаем заполнять массив и задаём
        //координаты ячейки, которую необходимо заполнить следующей.
    int c = 1;
    int d = 1;
 
    while (s < m * n)
    {
            //В Java инициализированный интовый массив заполняется нулями.
            //Периметр мы заполнили числами, отличными от нулей.
            //Следующие циклы поочерёдно работают, заполняя ячейки.
            //Вложенный цикл останавливается, если следующая ячейка имеет 
            //значение, отличное от ноля. Ячейка, на которой остановился 
            //цикл, не заполняется.
 
            //Движемся вправо.
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }
 
            //Движемся вниз.
        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }
 
            //Движемся влево.
        while (array[c, d - 1] == 0) 
        {
            array[c, d] = s;
            s++;
            d--;
        }
 
            //Движемся вверх.
        while (array[c - 1, d] == 0) 
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }
 
        //При данном решении в центре всегда остаётся незаполненная ячейка.
        //Убираем её при помощи следующего цикла.
    for (int x = 0; x < m; x++) 
    {
        for (int y = 0; y < n; y++) 
        {
            if (array[x, y] == 0) 
            {
                array[x, y] = s;
            }
        }
    }
 
        //Выводим массив в консоль.
    for (int x = 0; x < m; x++) 
    {
        for (int y = 0; y < n; y++) 
        {
            if (array[x, y] < 10)
            {
                    //Два пробела, чтобы в консоли столбцы были ровные.
                Console.WriteLine(array[x. y] + ",  ");
            } 
            else 
            {
                Console.WriteLine(array[x. y] + ", ");
            }
        }
        Console.WriteLine("");
        }
    }
     Console.WriteLine();

// }