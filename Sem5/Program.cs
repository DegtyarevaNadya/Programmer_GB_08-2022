Boolean forWhile = true;
while (forWhile)
{
Console.WriteLine("Введите номер задачи: 34, 36, 38; Help для справки; Exit для выхода");
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

int[] addIntArray(int size, int min = 0, int max = 999)
{
    
        int [] intArray = new int[size];
        Console.Write("[");
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = new Random().Next(min, max);
            
            if(i < intArray.Length-1)
            {
            Console.Write(intArray[i] + ", ");
            }
            else
            {
                Console.WriteLine(intArray[i] + "]");
            }
        }
        return intArray;
}

double[] addDoubleArray(int size, double min = 0.0, double max = 999.0)
{
        double [] doubleArray = new double[size];
        Console.Write("[");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            doubleArray[i] = new Random().NextDouble() * (max - min) + min;
            
            if(i < doubleArray.Length-1)
            {
            Console.Write("{0:.##}", doubleArray[i]);
            Console.Write(" ");
            }
            else
            {
                Console.Write("{0:.##}", doubleArray[i]);
                Console.WriteLine("]");
            }
        }
        return doubleArray;
}

switch(answer){

    case "34":
        // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        Console.WriteLine("Вы выбрали 34 задачу");
        Console.WriteLine("Введите размер массива, минимальное и максимальное значение");
        string[] arr= Console.ReadLine().Split();
 
        int sizeTo34 = int.Parse(arr[0]);
        int minTo34 = int.Parse(arr[1]);
        int maxTo34 = int.Parse(arr[2]);
        int count = 0;

        if(maxTo34 < minTo34)
            {
                int oper = maxTo34;
                maxTo34 = minTo34;
                minTo34 = oper;
            }


        int[] arrayTo34 = addIntArray(sizeTo34, minTo34, maxTo34);
        for (int i = 0; i < sizeTo34; i++)
        {
            if (arrayTo34[i] % 2 == 0)
            {
                Console.WriteLine($"Число {arrayTo34[i]} четное");
                count++;
            }
        }
        Console.WriteLine($"Всего в массиве {count} четных чисел");
        break;

    case "36":
    //  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        Console.WriteLine("Вы выбрали 36 задачу");
        Console.WriteLine("Введите размер массива, минимальное и максимальное значение");
        string[] arrTo36 = Console.ReadLine().Split();
 
        int sizeTo36 = int.Parse(arrTo36[0]);
        int minTo36 = int.Parse(arrTo36[1]);
        int maxTo36 = int.Parse(arrTo36[2]);
        int sumTo36 = 0;

        if(maxTo36 < minTo36)
            {
                int oper = maxTo36;
                maxTo36 = minTo36;
                minTo36 = oper;
            }


        int[] arrayTo36 = addIntArray(sizeTo36, minTo36, maxTo36);
        for (int i = 1; i < sizeTo36; i+=2)
        {
            sumTo36 = sumTo36 + arrayTo36[i];
        }
        Console.WriteLine($"Сумма чисел на нечетных позициях(первая позиция = 0) {sumTo36}");
        break;

    case "38":
        //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        Console.WriteLine("Вы выбрали 38 задачу");
        Console.WriteLine("Введите размер массива, минимальное и максимальное значение");
        string[] arrTo38 = Console.ReadLine().Split();
 
        int sizeTo38 = int.Parse(arrTo38[0]);
        double minTo38 = double.Parse(arrTo38[1]);
        double maxTo38 = double.Parse(arrTo38[2]);

        if(maxTo38 < minTo38)
            {
                double oper = maxTo38;
                maxTo38 = minTo38;
                minTo38 = oper;
            }


        double[] arrayTo38 = addDoubleArray(sizeTo38, minTo38, maxTo38);
        double maxArrTo38 = arrayTo38[0];
        double minArrTo38 = arrayTo38[0];

        for (int i = 0; i < sizeTo38; i++)
        {
            if(arrayTo38[i] < minArrTo38)
            {
                minArrTo38 = arrayTo38[i];
            }

            else if(arrayTo38[i] > maxArrTo38)
            {
                maxArrTo38 = arrayTo38[i];
            }

            
        }
        Console.Write("Получилось, что максимальное число в массиве: ");
        Console.Write("{0:.##}", maxArrTo38);
        Console.Write(" минимальное: ");
        Console.Write("{0:.##}", minArrTo38);
        Console.Write(" а разница между ними: ");
        Console.WriteLine("{0:.##}", maxArrTo38 - minArrTo38);
        break;
    
    case "Help":
        Console.WriteLine("Задача 34:  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine("Help: Показать список программ");
        Console.WriteLine("Exit: Выход из цикла");
        break;
    
    case "Exit":
        forWhile = false;
        break;

    default:
        Console.WriteLine("Ая-яй. Выбор строго ограничен: 10, 13, 15, Help или Exit");
        break;

}
}
