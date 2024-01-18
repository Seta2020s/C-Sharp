//Напишите программу,которая на вход примет два числа
//и выдает,какое число большее,а какое меньшее

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число : {number1}");
    Console.WriteLine($"Меньшее число : {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Большее число: {number2}");
    Console.WriteLine($"Меньшее число: {number1}");
}
else
{
    Console.WriteLine("Числа равны");
}