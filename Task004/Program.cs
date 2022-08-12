// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.

void NumberN(int number)
{
    int count = 1;
    while(count < number)
    {
        Console.Write($"{count*count}, ");
        count++;
    }
    Console.Write($"{count*count}. ");
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
NumberN(num);
