// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

if (numOne > numTwo) Console.Write("Большее число: " + numOne);
else Console.Write("Большее число: " + numTwo);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int numOne = Convert.ToInt32(Console.ReadLine());
// int max = numOne;
// Console.Write("Введите второе число: ");
// int numTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int numThree = Convert.ToInt32(Console.ReadLine());


// if (max < numTwo) max = numTwo;
// if (max < numThree) max = numThree;
// Console.Write("Большее число: " + max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0) Console.Write("Число " + number + " четное");
// else Console.Write("Число " + number + " НЕчетное");


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= number; i++){
//    if (i % 2 == 0) Console.Write(i + " "); 
// }

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write("Введите положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i = -number; i <= number; i++){
//    Console.Write(i + " "); 
// }

//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// string numberText = Console.ReadLine();
// if (numberText.Length > 2) Console.WriteLine("Третья цифра: " + numberText[2]);
