// // Задача 1: 

// Напишите программу, которая на вход принимает 
// // позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента 
// // или же указание, что такого элемента нет.


// int [,] array = new int [5,5];

// void CreateArray()
// {
//     for (int i=0; i<array.GetLength(0); i++ )
//     {
//         for (int j=0; j<array.GetLength(1); j++ )
//         {
//             array[i, j]=new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i=0; i<array.GetLength(0); i++ )
//     {
//         for (int j=0; j<array.GetLength(1); j++ )
//         {
//             System.Console.Write (array[i,j] + " ");
//         }
//         System.Console.WriteLine ();
//     }
    
// }
// void FindElArray()
// {   
// Console.WriteLine("Какую строку будем искать? Введите число: ");
// int l = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Какой столбец будем искать? Введите число: ");
// int c = Convert.ToInt32(Console.ReadLine());
           
//     if (l <= array.GetLength(0) - 1 && c <= array.GetLength(1) - 1)
//         {
//             Console.WriteLine("Значение элемента массива - " + " " + array[l, c]);
//          }                
//             else
//             {
//                 Console.WriteLine("Такого элемента нет");
//             }
//     Console.WriteLine();
// }

// CreateArray();
// FindElArray();
// PrintArray();





// Задача 2:
// Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// int [,] array = new int [7,4];

// void CreateArray()
// {
//     for (int i=0; i<array.GetLength(0); i++ )
//     {
//         for (int j=0; j<array.GetLength(1); j++ )
//         {
//             array[i, j]=new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i=0; i<array.GetLength(0); i++ )
//     {
//         for (int j=0; j<array.GetLength(1); j++ )
//         {
//             System.Console.Write (array[i,j] + " ");
//         }
//         System.Console.WriteLine ();
//     }
    
// }

// void ChangeArray ()
// {
//     for (int i = 0; i < array.GetLength(1); i++)
    
//         {
//             int temporary = array[0, i];
//             array[0, i] = array[array.GetLength(0)-1, i];
//             array[array.GetLength(0)-1, i] = temporary;
//         }
//     System.Console.WriteLine ();
//     System.Console.WriteLine ("Массив, где первую строчку поменяли местом с последней: ");
// } 
    

// CreateArray();
// PrintArray();
// ChangeArray();
// PrintArray();





// Задача 3

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.


int [,] array = new int [5,3];

void CreateArray()
{
    for (int i=0; i<array.GetLength(0); i++ )
    {
        for (int j=0; j<array.GetLength(1); j++ )
        {
            array[i, j]=new Random().Next(1, 10);
        }
    }
}
void PrintArray()
{
    for (int i=0; i<array.GetLength(0); i++ )
    {
        for (int j=0; j<array.GetLength(1); j++ )
        {
            System.Console.Write (array[i,j] + " ");
        }
        System.Console.WriteLine ();
    }
    
}

void SumStringArray(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[index, j] + " ";
    }
    Console.WriteLine($"Минимальная сумма элементов строки равна {minsum}, а ее индекс - {index}");
}
CreateArray();
PrintArray();
SumStringArray(array);
