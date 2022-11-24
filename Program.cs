// Урок 6. Двумерные массивы и рекурсия

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Input a length of array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Input {i+1} element of array: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// int count = 0;
// for (int i = 0; i < array.Length; i++)
//     if (array[i] > 0)
//         {
//             count++;
//         }

// Console.WriteLine($"Digits more than 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Input value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;

Console.WriteLine($"Point: ({x}; {y})");