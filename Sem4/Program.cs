Boolean forWhile = true;
while (forWhile)
{
Console.WriteLine("Введите номер задачи: 25, 27, 29; Help для справки; Exit для выхода");
string answer = Convert.ToString(Console.ReadLine());

Boolean itISIntMumber(string maybeMumber)
{
    int num;
    double numD;

    if (int.TryParse(maybeMumber, out num)){
        Console.WriteLine($"{maybeMumber} целое число!");
        return true;
        }
        else if (Double.TryParse(maybeMumber, out numD)) {
            Console.WriteLine($"{maybeMumber} не целое число!");
            return false;
        }
        else {
            Console.WriteLine($"{maybeMumber} не число!");
            return false;
        }
}

switch(answer){

    case "25":
        //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        Console.WriteLine("Вы выбрали 25 задачу");
        Console.WriteLine("Введите число");
        string numberTo25 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите степень числа");
        string degree = Convert.ToString(Console.ReadLine());

        if(itISIntMumber(numberTo25))
        {   
            int intNumberTo25 = Convert.ToInt32(numberTo25);
            int answerTo25 = Convert.ToInt32(numberTo25);
            if(itISIntMumber(degree))
            {   
                int intDegree = Convert.ToInt32(degree);
                for (int i = 1; i < intDegree; i++)
                {
                    answerTo25 = answerTo25 * intNumberTo25;
                }
                Console.WriteLine($"{intNumberTo25} в степени {intDegree} равно {answerTo25}");
            }
        }
        else
        {
            Console.WriteLine("Попробуйте еще раз");
        }
        break;

    case "27":
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        Console.WriteLine("Вы выбрали 27 задачу");
        Console.WriteLine("Введите число");
        string numberTo27 = Convert.ToString(Console.ReadLine());
        if(itISIntMumber(numberTo27))
        {
            int intNumberTo27 = Convert.ToInt32(numberTo27);
            int sumDigits = 0;
            while (intNumberTo27 > 0)
            {
                int num = intNumberTo27 % 10;
                intNumberTo27 = intNumberTo27 / 10;
                sumDigits = sumDigits + num;
            }
            Console.WriteLine($"Cумма всех цифр в числе {numberTo27} равна {sumDigits}");
        }
        else
        {
            Console.WriteLine("Попробуйте еще раз");
        }
        break;

    case "29":
        //  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        Console.WriteLine("Вы выбрали 29 задачу");
        Console.WriteLine("Введите размер массива");
        string numberTo29 = Convert.ToString(Console.ReadLine());
        if(itISIntMumber(numberTo29))
        {
        int [] numbers = new int[Convert.ToInt32(numberTo29)];
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0, 999);
            if(i < numbers.Length-1)
            {
            Console.Write(numbers[i] + ", ");
            }
            else
            {
                Console.WriteLine(numbers[i] + "]");
            }
        }
        }
        else
        {
            Console.WriteLine("Попробуйте еще раз");
        }
        break;
    
    case "Help":
        Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        Console.WriteLine("Help: Показать список программ");
        Console.WriteLine("Exit: Выход из цикла");
        break;
    
    case "Exit":
        forWhile = false;
        break;

    default:
        Console.WriteLine("Ая-яй. Выбор строго ограничен: 25, 27, 29; Help для справки; Exit для выхода");
        break;

}
}
