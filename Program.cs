﻿// // Задача 1: 

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
