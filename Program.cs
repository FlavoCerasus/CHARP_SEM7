// Рекурсия

/* Задание 1 - Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
(Указание - Использовать рекурсию)

Пример:
123 => 6
63 => 9
*/
/*
int FindSum (int number)
{
    if (number == 0)
        return 0;
    int sum = number % 10 + FindSum(number/10);
    return sum;
}

Console.Write("Enter a number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = FindSum(userNumber);
Console.WriteLine($"Sum of digits is {sumOfDigits}.");
*/

/* Задание 2 - Считать строку с консоли, содержащую латинские буквы. 
Вывести на экран согласные буквы этой строки.
(Указание - Использовать рекурсию. Не использовать цикл)

Пример:
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d
*/
/*
void ShowConsLetters(string user_str)
{
    if (user_str.Length == 0)
        return;
    string vowelLetters = "eyuioaEYUIOA";
    if (!vowelLetters.Contains(char.ToLower(user_str[0])) && char.IsAsciiLetter(user_str[0]))
        Console.Write($"{user_str[0]} ");
    ShowConsLetters(user_str.Substring(1));
}

ShowConsLetters("What the f*ck is g0ing?");
// string user_str.Substring(1); // метод для посимвольного движения с указананного символа и до конца строки
*/

// Домашнее задание!

/* Задача 1 - Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N. 
(Использовать рекурсию, не использовать циклы)

Пример:
M = 1; N = 5 ---> "1, 2, 3, 4, 5"
M = 4; N = 8 ---> "4, 5, 6, 7, 8"
*/
/*
void ShowNumbers(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    ShowNumbers(m+1, n);
}
void ShowNumberAnotherWay(int m, int n)
{
    if (n > m) return;
    ShowNumberAnotherWay(m, n+1);
    Console.Write($"{n} ");
}

Console.Write("Enter a number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM == numberN) Console.WriteLine(numberM);
else if (numberN > numberM) ShowNumbers(numberM,numberN);
else ShowNumberAnotherWay(numberM, numberN);
*/


/* Задача 2 - Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

Пример:
m = 2; n = 3 ---> A(m,n) = 29
*/
/*
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return 0;
}
bool IsThatNatNumbs (int m, int n)
{
    if (m >= 0 && n >= 0) return true;
    else 
    {
        Console.WriteLine("One or both numbers are negative. Check and enter numbers again.");
        return false;
    }
}

int userM, userN;
while (true)
{
Console.Write("Enter a non-negative number m: ");
userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a non-negative number n: ");
userN = Convert.ToInt32(Console.ReadLine());
if (IsThatNatNumbs(userM, userN) == true) break;
else continue;
}
Console.WriteLine($"A({userM}, {userN}) = {AckermannFunction(userM, userN)}");
*/

/* Задача 3 - Задайте произвольный массив. Выведете его элементы, начиная с конца. 
(Использовать рекурсию, не использовать циклы)

Пример:
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
*/
/*
int [] CreateRandomArray(int size)
{
    int [] randomArr = new int [size]; 
    for (int i = 0; i < randomArr.Length; i++)
        randomArr[i] = new Random().Next(0, 101);
    return randomArr;
}
void PrintArray(int [] array, int size)
{
    if (size < 0) return;
    //Console.Write($"{array[size]} ");
    PrintArray(array, size -1);
    Console.Write($"{array[size]} ");
}
void PrintReversedArray(int [] array, int size)
{
    if (size < 0) return;
    Console.Write($"{array[size]} ");
    PrintReversedArray(array, size -1);
    //Console.Write($"{array[size]} ");
}


Console.Write("Enter the number of array elements:");
int userArrSize = Convert.ToInt32(Console.ReadLine());
int [] RandArr = CreateRandomArray(userArrSize);
Console.Write($"Created array: ");
PrintArray(RandArr, RandArr.Length - 1);
Console.WriteLine();
Console.Write("Reversed array: ");
PrintReversedArray(RandArr, RandArr.Length - 1);
*/