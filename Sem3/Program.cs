Console.WriteLine("Введите номер задачи: 19, 21, 23 или Help");
string answer = Convert.ToString(Console.ReadLine());

switch(answer){
    case "19":
        Console.WriteLine("Вы выбрали 19 задачу");
        Console.WriteLine("Введите пятизначное число");
        string numberTo19 = Convert.ToString(Console.ReadLine());
        int numTo19;
        double numDTo19;

        void palindromeСheck(string number)
        {
        if (numberTo19[0]==numberTo19[4] || numberTo19[1]==numberTo19[3])
            {
                Console.WriteLine($"Число: {numberTo19} - палиндром.");
            }
            else Console.WriteLine($"Число: {numberTo19} - НЕ палиндром.");
        }   

        if (int.TryParse(numberTo19, out numTo19))
        {
            if(numberTo19.Length == 5) 
            {
                Console.WriteLine("Это пятизначное число");
                palindromeСheck(numberTo19);
            }
            else 
            {
                Console.WriteLine("Это не пятизначное число");
            }
        }
        else if (Double.TryParse(numberTo19, out numDTo19)) {
            Console.WriteLine("Это не целое число!");
        }
        else {
            Console.WriteLine("Это не число!");
        }
        break;

    case "21":
        Console.WriteLine("Вы выбрали 21 задачу");
        
        int x1 = Coordinates("x", "A");
        int y1 = Coordinates("y", "A");
        int z1 = Coordinates("z", "A");
        int x2 = Coordinates("x", "B");
        int y2 = Coordinates("y", "B");
        int z2 = Coordinates("z", "B");

        int Coordinates(string coordinate, string point)
        {
            Console.Write($"Введите координату {coordinate} точки {point}: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        double answerCoordinates(double x1, double x2, 
                                double y1, double y2, 
                                double z1, double z2)
        {
            return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
        }

        double distance =  Math.Round(answerCoordinates(x1, x2, y1, y2, z1, z2), 2 );
        Console.WriteLine($"Расстояние между точками  {distance}");
        break;

    case "23": 
        Console.WriteLine("Вы выбрали 23 задачу"); 
        Console.WriteLine("Введите число");
        int numberTo23 = Convert.ToInt32(Console.ReadLine());

        void Cubes(int numberTo23)
        {
            Console.WriteLine($"Ваше число: {numberTo23}");
            for (int i = 1; i <= numberTo23; i++)
            {
                Console.Write($"{i*i*i} ");
            }
        }

        Cubes(numberTo23);
        break;

    default:
        Console.WriteLine("Ая-яй. Выбор строго ограничен: 19, 21, 23 или Help");
        break;

}