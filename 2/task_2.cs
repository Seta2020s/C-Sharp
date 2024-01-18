//Напишите программу,которая выводит третью цифру заданного числа
// или сообщает,что третьей цифры нет

Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = number / 100;

        if (thirdDigit != 0)
        {
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("У заданного числа нет третьей цифры.");
        }