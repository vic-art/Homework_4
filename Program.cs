// Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int A, B;
Console.WriteLine("Введите число А:");
int.TryParse(Console.ReadLine()!, out A);

Console.WriteLine("Введите число B:");
int.TryParse(Console.ReadLine()!, out B);


Console.WriteLine($"{A} в степени {B} = {Power(A, B)}");


int Power(int _A, int _B)
{
    int result = 1;
    for (int i = 0; i < _B; i++)
    {
        result *= _A;
    }
    return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int N;

Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine()!, out N);

Console.WriteLine($"Сумма всех цифр в числе = {Sum(N)}");


int Sum(int _N)
{
    int result = 0;
    int temp = _N;
    while (temp != 0)
    {
        result += temp % 10;
        temp /= 10;
    }
    return result;
}



// Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

foreach (var item in PrintArray())
{
    Console.Write($"{item} ");
}

int[] PrintArray()
{
    int[] _array = new int[8];
    for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(100);
    }
    return _array;
}


