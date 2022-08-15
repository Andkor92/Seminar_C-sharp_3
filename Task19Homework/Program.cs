// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: "); //ВАРИАНТ №1 - Только для пятизначных чисел (согласно условию)
int number = Convert.ToInt32(Console.ReadLine());
int first = 1;
int firstDigit = number / (10000 / first) % 10;
int last = 1;
int lastDigit = number / last % 10;

if (number > 9999 && number < 100000)
{
    for (int i = 1; i < 2; i++)
    {
        if (firstDigit == lastDigit)
        {
            first = first * 10;
            firstDigit = number / (10000 / first) % 10;
            last = last * 10;
            lastDigit = number / last % 10;
        }
        if (firstDigit == lastDigit)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}
else
{
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}

Console.WriteLine("Введите пятизначное число: "); //ВАРИАНТ №2 - Универсальный алгоритм :)
int number = Convert.ToInt32(Console.ReadLine());
int numberLen = (int)Math.Log10(number);
int first = numberLen;
int last = 1;
int firstDigit = (int)(number / Math.Pow(10, numberLen));
int lastDigit = (number / last) % 10;

if (numberLen == 4) //Если убрать проверку этого условия, то решение будет доступно для чисел от 1 до 2,147,483,647 :)
{
    for (int i = 1; i <= ((numberLen + 1) / 2); i++)
    {
        if (firstDigit == lastDigit)
        {
            first = first - 1;
            last = last * 10;
            firstDigit = (int)(number / Math.Pow(10, first) % 10);
            lastDigit = (number / last) % 10;
        }
    }
    if (firstDigit == lastDigit)
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
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}

Console.WriteLine("Введите пятизначное число: "); //ВАРИАНТ №3 - Через строку
string number = Convert.ToString(Console.ReadLine());
int index = 0;
int digitIndex = number.Length - 1;

if (number.Length == 5)
{
    if (number[index] == number[digitIndex])
    {
        for (int i = 1; i <= ((number.Length - 1) / 2); i++)
        {
            if (number[index] == number[digitIndex])
            {
                index++;
                digitIndex--;
            }
        }
        if (number[index] == number[digitIndex])
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
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}
