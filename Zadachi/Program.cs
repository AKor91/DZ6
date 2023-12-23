// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// int num1 = new Random().Next(1,6);
// System.Console.WriteLine("Наше первое число "+ num1);

// int num2 = new Random().Next(6,13);
// System.Console.WriteLine("Наше второе число "+ num2);

// int firstElement = num1;

// PrintNumbers(firstElement,num2);

// void PrintNumbers(int startEl, int endEl)
// {
//     System.Console.WriteLine(startEl);

//     if(startEl == endEl)
//     {
//         return;
//     }

// PrintNumbers(startEl+1, endEl);
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = AckermannFunction(m, n);

// Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");

// int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }

// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] Array = { 1, 2, 3, 4, 5 };
        
//     Console.WriteLine("Элементы массива, начиная с конца:");
//     PrintArrayReversed(Array, Array.Length - 1);

// void PrintArrayReversed(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.WriteLine(array[index]);
//         PrintArrayReversed(array, index - 1);
//     }
// }