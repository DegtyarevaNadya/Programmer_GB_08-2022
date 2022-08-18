Console.WriteLine("Введите номер задачи: 10, 13, 15 или Help");
string answer = Convert.ToString(Console.ReadLine());

switch(answer){

    case "10":
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
        Console.WriteLine("Вы выбрали 10 задачу");
        Console.WriteLine("Введите трехзначное число");
        string number = Convert.ToString(Console.ReadLine());
        int num;
        double numD;
        if (int.TryParse(number, out num)){
            if(number.Length == 3) {
                Console.WriteLine("Это трехзначное число");
                Console.WriteLine("Вторая цифра этого числа -> " + number[1]);
            }
            else {
                Console.WriteLine("Это не трехзначное число");
            }
        }
        else if (Double.TryParse(number, out numD)) {
            Console.WriteLine("Это не целое число!");
        }
        else {
            Console.WriteLine("Это не число!");
        }
        break;

    case "13":
    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
        Console.WriteLine("Вы выбрали 13 задачу");
        Console.WriteLine("Введите трехзначное число");
        string numberTo13 = Convert.ToString(Console.ReadLine());
        int numTo13;
        double numDTo13;
        if (int.TryParse(numberTo13, out numTo13)){
            if(numberTo13.Length == 3) {
                Console.WriteLine("Это трехзначное число");
                Console.WriteLine("Третья цифра этого числа -> " + numberTo13[2]);
            }
            else {
                Console.WriteLine("Это не трехзначное число");
                if(numberTo13.Length > 3){
                    Console.WriteLine("Это больше, чем трехзначное число");
                    Console.WriteLine("Но третья цифра этого числа -> " + numberTo13[2]);
                } 
                else {
                    Console.WriteLine("Это меньше, чем трехзначное число. Третьей цифры нет!");
                }
            }
        }
        else if (Double.TryParse(numberTo13, out numD)) {
            Console.WriteLine("Это не целое число!");
        }
        else {
            Console.WriteLine("Это не число!");
        }
        break;

    case "15":
        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        Console.WriteLine("Вы выбрали 15 задачу");
        Console.WriteLine("Введите число от 1 до 7");
        string numberTo15 = Convert.ToString(Console.ReadLine());
        int numTo15;
        if (int.TryParse(numberTo15, out numTo15)){
            if (numTo15 > 0 && numTo15 < 8){
                if (numTo15 == 6 || numTo15 == 7) {
                Console.WriteLine("Этот день выходной");
                } else{
                   Console.WriteLine("Этот день не выходной, он рабочий"); 
                }
            } else{
                Console.WriteLine("Это не число от 1 до 7");
            }

        } else {
            Console.WriteLine("Это не число от 1 до 7");
        }
        break;
    
    case "Help":
        Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
        Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine("Help: Показать список программ");
        break;

    default:
        Console.WriteLine("Ая-яй. Выбор строго ограничен: 10, 13, 15 или Help");
        break;

}

