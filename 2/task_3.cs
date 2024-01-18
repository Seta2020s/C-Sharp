//Напишите программу,которая принимает на вход цифру,
// обозначающую день недели,и проверяет,является ли этот день выходным

Console.WriteLine("Введите цифру дня недели (1-7):");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Этот день является выходным.");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным.");
        }