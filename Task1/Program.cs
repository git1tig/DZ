


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int PosInNum(double number, int position, double i) // i - определяет количество разрядов числа!
{

    int CurrentPosition = 0;
    int CurrentPosNumber = 0;
    i = i - 1; // делить начнём с 10 в степени i-1

    if (number < 10)
    {
        CurrentPosNumber = Convert.ToInt32(number);
        if (position > 1) CurrentPosNumber = -1; // если изначально ввели однозначное число, а разряд хотят получить отличный от 1
        return CurrentPosNumber;
    }

    while (i > 0)
    {

        if (number / Math.Pow(10, i) > 1)
        {
            // Console.WriteLine("number / Math.Pow(10, i) > 1 !!!");
            // Console.WriteLine("Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);

            CurrentPosition++;
            // Console.WriteLine("CurrentPosition++;" + CurrentPosition);
            // Console.WriteLine("now position  is " + CurrentPosition);
            CurrentPosNumber = Convert.ToInt32(Math.Truncate(number / Math.Pow(10, i)));
            // Console.WriteLine("currentPosNumber is " + CurrentPosNumber);

            if (CurrentPosition == position)
            {
                // Console.WriteLine("Приехал к нужной позиции!");
                // Console.WriteLine("Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);
                return CurrentPosNumber;
            }

            number = number % Math.Pow(10, i);
        }
        i = i - 1;
        // Console.WriteLine("Уходим на след круг цикла   Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);
        if (i == 0)
        {
            CurrentPosition++;
            // Console.WriteLine("CurrentPosition++;" + CurrentPosition);
            // Console.WriteLine("now position  is " + CurrentPosition);
            CurrentPosNumber = Convert.ToInt32(Math.Truncate(number / Math.Pow(10, i)));

            if (CurrentPosition < position)
            {
                CurrentPosNumber = -1;
                // Console.WriteLine("CurrentPosition<position");
                return CurrentPosNumber;


            }
            CurrentPosNumber = Convert.ToInt32(number);
            return CurrentPosNumber;
            Console.WriteLine("i=0!");
        }

    }
    // Console.WriteLine("перед  выходом: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber);
    return CurrentPosNumber;

}

int MyNum = 0;


Console.Write("Введите любое пятизначное число: ");
while (!Int32.TryParse(Console.ReadLine(), out MyNum) || MyNum < 10000 || MyNum > 99999)
{
    Console.WriteLine("Ввод " + MyNum + " неверный. Пожалуйста, введите корректное число");
}
if (PosInNum(MyNum, 1, 5) == PosInNum(MyNum, 5, 5) && PosInNum(MyNum, 2, 5) == PosInNum(MyNum,4,5))
    Console.WriteLine("Число " + MyNum + "-это палиндром!");
else 
    Console.WriteLine("Число " + MyNum + "-это не палиндром!");
