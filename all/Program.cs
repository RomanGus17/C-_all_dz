

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
