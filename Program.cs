//Однострочный коментарий вид так"//" 
//Многострочный комментарий вид так "/*текст*/"

// Задача 1
// Принять любое число и выдать его квадрат.

// Console.WriteLine("Ввести число ");
// int num = int.Parse(Console.ReadLine()!);
// //Математический тип решения.
// int numA = num * num;
// //Библиотечный тип решения.
// int num1 = Convert.ToInt32(Math.Pow(num, 2));
// Console.WriteLine($"Квадрат числа {num} является число: математический {numA}, с библиотекой {num1}. ");

//Задача 2
//Принять любое число (N).
//Показать на выходе все целые числа в промежутке от(N) до (N)

// Console.WriteLine("Ввести число ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = -num;

// while(num1 <= num){
//     Console.WriteLine($"{num1} "); //WriteLine выводит в новой строке отдельное число.
//     num1 ++;
// }

//Пример 2
// Console.WriteLine("Ввести число ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = -num;

// while(num1 <= num){
//     Console.Write($"{num1} "); //Write выводит в одной строке отдельное число.
//     num1 ++;
// }

//Задача 3
//Принять два числа и проверить являеться ли первое число квадратом второго.
// Console.Write("Введите первое число ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write("Введите второе число ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if(num1 == Convert.ToInt32(Math.Pow(num2, 2))){
//     Console.WriteLine($"Число {num1} являеться квадратом {num2} ");
// }
// else{
//     Console.WriteLine($"Число {num1} не являеться квадратом {num2} ");
// }

//Пример 2
//Принять два числа и проверить являеться ли первое число квадратом второго.
// Console.Write("Введите первое число ");
// double num1 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write("Введите второе число ");
// double num2 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if(num1 == Math.Pow(num2, 2)){
//     Console.WriteLine($"Число {num1} являеться квадратом {num2} ");
// }
// else{
//     Console.WriteLine($"Число {num1} не являеться квадратом {num2} ");
// }

//Задача 4
//Название дня недели по заданному номеру.
// Console.Write("Введите номер дня: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if(num == num)
//    Console.WriteLine("Введите число от 1 до 7! ");

// if(num == 1)
//    Console.WriteLine("Воскресенье. ");

// if(num == 2)
//    Console.WriteLine("Понедельник. ");

// if(num == 3)
//    Console.WriteLine("Вторник. ");

// if(num == 4)
//    Console.WriteLine("Среда. ");

// if(num == 5)
//    Console.WriteLine("Четверг. ");

// if(num == 6)
//    Console.WriteLine("Пятница. ");

// if(num == 7)
//    Console.WriteLine("Суббота. ");

//Задача 5
//Из многозначного числа,
//на выходе показать последнее число.

// Console.WriteLine("Введите трехзначное число. ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = num % 10;
// Console.WriteLine($"Последнее число; ");
// Console.WriteLine($"{num % 10};");

//Задача 6 ДЗ: 
//принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.
//Пример 1
// Console.Write("Введите число 1; ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2; ");
// int b = Convert.ToInt32(Console.ReadLine());
// //Console.Clear();
// if(a > b)
// Console.WriteLine("Первое число больше. ");
// if(a < b)
// Console.WriteLine("Второе число больше. ");

//Пример 2
// int a = 1;
// int b = 2;

// if(a > b){
//     Console.WriteLine($"Число { a } больше числа { b } ");
// }
// else if(a < b){
//     Console.WriteLine($"Число { a } меньше числа { b } ");

// }

//Задача 7 ДЗ: 
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.


// Console.Write("Введите первое число; ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число; ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число; ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;

// if (a > max ) max = a; 
// if (b > max ) max = b; 
// if (c > max ) max = c; 
// Console.Write("max = "); 
// Console.WriteLine(max);

//Задача 8 ДЗ:
// Напишите программу, которая на вход
// принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//Console.Write("Введите  число; ");
//int a = Convert.ToInt32(Console.Read());
//for (int x = 1; x <= a; x++);
//   if (x % 2 == 0) 
//   Console.WriteLine($"Четное, Делиться без остатка!{  x  }; ");
//   else 
//   Console.WriteLine("Нечетное, Не делиться без остатка! ");

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
    
// for (int b = 1; b <= a; b++)
//     if (b % 2 == 0)
//         Console.Write( b );

//Делиться на два без остатка "Да""Нет" не делиться
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num % 2;

// if(num1 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 4:
// Принимает число (N), 
// А на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);

int Num = 2;

if(num > 1)
{
    while(Num <= num)
    {
        Console.Write(Num + " ");
        Num = Num + 2;
    }
}


