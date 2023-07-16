// Задача 27. 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input("Введите число: ");

int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine(sum);