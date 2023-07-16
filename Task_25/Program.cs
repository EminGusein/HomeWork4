// Задача 25.
// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = Input("Введите число А: ");
int numberB = Input("Введите число В: ");

int result = numberA;
for (int i = 1; i < numberB; i++) result = result * numberA;
Console.WriteLine($"{numberA}^{numberB} = {result}");

