// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void CubeLine(int n)
{
    int i=1;
    while(i<=n)
    {
        Console.Write(Math.Pow(i,3)+ " ");
        i++;
    }
}

int number;
Console.Write("Введите целое число:");
    while (!Int32.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    }

CubeLine(number);