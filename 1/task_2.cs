//Напишите программу,которая принимает на вход три числа
// и выдает максимальное из этих чисел


Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int maxNumber = Math.Max(number1, Math.Max(number2, number3));
Console.WriteLine($"Максимальное число: {maxNumber}");