// Задача 29.
// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

int size = 8;
Random rnd = new Random();
int[] numbers = new int[size];

void Print(int[] numbers)
{

    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(-100, 100);
    }

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void Sort(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        int min = i;

        for (int j = i; j < size; j++)
        {
            if (Math.Abs(numbers[j]) < Math.Abs(numbers[min])) min = j;
        }

        int temp = numbers[i];
        numbers[i] = numbers[min];
        numbers[min] = temp;
    }

     for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

Print(numbers);
Sort(numbers);

