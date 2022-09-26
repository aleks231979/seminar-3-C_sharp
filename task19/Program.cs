// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 10000 && number < 100000)
{
    int number1 = number / 10000;
    int number2 = number / 1000;
    number2 = number2 % 10;
    int number4 = number / 10;
    number4 = number4 % 10;
    int number5 = number % 10;

    if(number1 == number5 && number2 == number4)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Введено не верное число.");
}
