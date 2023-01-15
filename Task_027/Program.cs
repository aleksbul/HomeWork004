// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.


// СПОСОБ 1 (через массив)

// int Sum(int number)
// {
//     number = Math.Abs(number);
//     string str = number.ToString();

//     int[] array = new int[str.Length];
//     int sum = 0;
//     for (int i = 0; i < str.Length; i++)
//     {
//         array[i] = int.Parse(str[i].ToString());
//         sum = sum + array[i];
//     }
//     return sum;
// }

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма цифр числа {number} равна {Sum(number)}");

// СПОСОБ 2 (с помошью деления)

int Sum(int number)
{
    number = Math.Abs(number);
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} равна {Sum(number)}");