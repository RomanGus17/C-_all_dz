//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Например 
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// Console.WriteLine("Введите размер строк массива");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размер колонок массива");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-10, 11)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// double[,] numbers = new double[QuantityLines, QuantityColumns];
// FillArrayRandomRealNumbers(numbers);
// PrintArray(numbers);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

// Console.WriteLine("Введите строку позиции элемента");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колоноку позиции элемента");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbersInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }


// int [,] numbers = new int [10,10];
// FillArrayRandomRealNumbersInt(numbers);

// if (QuantityLines > numbers.GetLength(0) || QuantityColumns > numbers.GetLength(1))
// {
//     Console.WriteLine("такого числа в массиве нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента = {numbers[QuantityLines-1,QuantityColumns-1]}");
// }

// PrintArrayInt(numbers);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите размер строк массива");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размер колонок массива");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbersInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// int[,] numbers = new int[QuantityLines, QuantityColumns];

// FillArrayRandomRealNumbersInt(numbers);

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double average = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         average = (average + numbers[i, j]);
//     }
//     average = average / QuantityLines;
//     Console.WriteLine($"Среднее арифметическое столбцов по порядку: {average}" + "; ");
// }
// Console.WriteLine();
// PrintArrayInt(numbers);

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Например: 
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

// Console.Write("Введите числа: ");
// int[] num = StringToNum(Console.ReadLine());

// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ' ')
//         {
//             count++;
//         }
//     }

//     int[] num = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ' ')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         num[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return num;
// }

// int sum = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0 = {sum}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//Например:
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToInt32(Console.ReadLine());


// double x = (b2 - b1) / (k1 - k2);
// double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

// Console.WriteLine($"точка пересечения двух прямых -> ({x}; {y})");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Например: [345, 897, 568, 234] -> 2

// void FillArray(int[] num) //функция, которая создает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(100,1000);
//     }
// }

// void PrintArray(int[] num) //функция, которая показывает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.Write("");
// }

// int[] num = new int[4];
// int cnt = 0;

// void EvenNumbers(int[] num) //функция, которая вычисляет кол-во четных чисел
// {
//     for (int a = 0; a < num.Length; a++)
//     if (num[a] % 2 == 0)
//     cnt++;
// }

// FillArray(num);
// PrintArray(num);
// EvenNumbers(num);
// Console.Write($"-> {cnt}");



//-------------------------------------------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Например:
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// void FillArray(int[] num) //функция, которая создает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(-100,100);
//     }
// }

// void PrintArray(int[] num) //функция, которая показывает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.Write("");
// }


// void EvenPozition(int[] num) //функция, которая вычисляет сумму чисел на четных позициях
// {
//     int sum = 0;
//     for (int a = 0; a < num.Length; a+=2)
//     sum = sum + num[a];
//     Console.Write($"{sum}");
// }

// int[] num = new int[4];

// FillArray(num);
// PrintArray(num);
// EvenPozition(num);


//-------------------------------------------------------------------------------------------------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Например:
//[3 7 22 2 78] -> 76

// void FillArray(int[] num) //функция, которая создает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(1,100);
//     }
// }

// void PrintArray(int[] num) //функция, которая показывает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.WriteLine("");
// }

// void Difference(int[] num) //функция, которая вычисляет разницу максимального и минимального значений
// {
//     double min = Int32.MaxValue;
//     double max = Int32.MinValue;

//     for (int a = 0; a < num.Length; a++)
//     {
//         if (num[a] > max)
//             {
//                 max = num[a];
//             }
//         if (num[a] < min)
//             {
//                 min = num[a];
//             }
//     }
//     Console.WriteLine($"MAX = {max}, MIN = {min}. Разница = {max - min}");
// }

// int[] num = new int[5];
// FillArray(num);
// PrintArray(num);
// Difference(num);

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите первое число"); //Вводим первое число
// int a = int.Parse(Console.ReadLine()); //Кладем первое число в переменную
// Console.WriteLine("Введите второе число"); //Вводим второе число
// int b = int.Parse(Console.ReadLine()); //Кладем второе число в переменную

// int temp = 1;
// double rez = 1;

// while (temp <= b)
// {
//     rez = (Math.Pow(a, b));
//     ++temp;
// }
// Console.WriteLine(rez);


//--------------------------------------------------------------------------------------------
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// int Sum(int a)
// {    
//     int n = Convert.ToString(a).Length;
//     int temp = 0;
//     int res = 0;

//     for (int i = 0; i < n; ++i){
//       temp = a - a % 10;
//       res = res + (a - temp);
//       a = a / 10;
//     }
//    return res;
//   }

// int sum = Sum(a);
// Console.WriteLine(sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Для первого массива
// int [] arr = {1, 2, 5, 7, 19};

// int cnt = arr.Length;

// for (int i = 0; i < cnt; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();


//Для второго массива
// int [] arr = {6, 1, 33};

// int cnt = arr.Length;

// for (int i = 0; i < cnt; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();

//----------------------------------------------------------------------------------------------------------------------
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Введите пятизначное число");
// int N = int.Parse(Console.ReadLine());

// void Palindrom(int num)
// {
//     int del1 = num / 10000;
//     int ost1 = num % 10;

//     if(del1 == ost1)
//     {
//         num = num / 10;
//         int del2 = (num / 100) % 10;
//         int ost2 = num % 10;
//         if(del2 == ost2)
//             Console.WriteLine("Да");
//     }
//     else 
//     Console.WriteLine("Нет");
// }

// Console.WriteLine("Введите пятизначное число:");
// int number = int.Parse(Console.ReadLine()!);
// Palindrom(number);

//----------------------------------------------------------------------------------------------------------------------
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double xa = 7;
// double xb = 1;
// double ya = -5;
// double yb = -1;
// double za = 0;
// double zb = -9;

// double koren = Math.Sqrt(Math.Pow(xb - xa, 2)+Math.Pow(yb - ya, 2)+Math.Pow(zb - za, 2));

// Console.WriteLine(koren);

//----------------------------------------------------------------------------------------------------------------------
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("Vvedi N");
// double N = int.Parse(Console.ReadLine());
// double res = 1;

// while (res <= N)
// {
//     Console.WriteLine(Math.Pow(res, 3));
//     ++res;
// }

//-------------------------------------------------------------------------
//Задача 10
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int EnterNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(EnterNumber);
// Console.WriteLine("Вторая цифра введенного числа = "+strNumber[1]);

//----------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int EnterNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(EnterNumber);
// if (strNumber.Length > 2)
// {
//     Console.WriteLine("Третья цифра введенного числа = "+strNumber[2]);
// } 
// else     
//     Console.WriteLine ("третьей цифры нет");


//----------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// void NumberOfTheDayOfTheWeek (int dayNum) {

//   if (dayNum == 6 || dayNum == 7) {
//   Console.WriteLine("Выходной день");
//   }
//   else if (dayNum < 1 || dayNum > 7) {
//     Console.WriteLine("Ошибка. Введите цифру от 1 до 7");
//   }
//   else Console.WriteLine("Будний день");
// }
// NumberOfTheDayOfTheWeek(dayNum);

//-------------------------------------------------------------------------
//Задача 8
// Первое условие
// int a = 1;
// int n = 5;
// for (int i = a; i <= n; i++)
// {
//     if (i % 2 == 0) 
//     {
//         Console.Write(i + ", ");
//     }
// }
// Console.WriteLine();

// Второе условие
// int a = 1;
// int n = 8;
// for (int i = a; i <= n; i++)
// {
//     if (i % 2 == 0) 
//     {
//         Console.Write(i + ", ");
//     }
// }
// Console.WriteLine();

//-------------------------------------------------------------------------
//Задача 6
// Первое условие
// int n = 4; 
//  if (n % 2 == 0)
//     {
//         Console.Write("Четное");
//     }
// else
//     {
//         Console.Write("Нечетное");
//     }

// Второе условие
// int n = -3; 
//  if (n % 2 == 0)
//     {
//         Console.Write("Четное");
//     }
// else
//     {
//         Console.Write("Нечетное");
//     }

// Третье условие
// int n = 7; 
//  if (n % 2 == 0)
//     {
//         Console.Write("Четное");
//     }
// else
//     {
//         Console.Write("Нечетное");
//     }

//-------------------------------------------------------------------------
//Задача 4
// Первое условие

// int a = 5;
// int b = 3;
// int c = 7;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// Console.Write("max = ");
// Console.WriteLine(max);


//Второе условие
// int a = 44;
// int b = 5;
// int c = 78;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// Console.Write("max = ");
// Console.WriteLine(max);

//Третье условие
// int a = 22;
// int b = 3;
// int c = 9;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// Console.Write("max = ");
// Console.WriteLine(max);

//-------------------------------------------------------------------------
//Задача 2
// Первое условие

// int a = 5;
// int b = 7;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// Console.Write("max = ");
// Console.WriteLine(max);


//Второе условие

// int a = 2;
// int b = 10;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// Console.Write("max = ");
// Console.WriteLine(max);


//Третье условие

// int a = -9;
// int b = -3;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// Console.Write("max = ");
// Console.WriteLine(max);
