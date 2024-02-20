// Задача 1:
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void ShowNumbers(int m, int n)
{
if (m == n) 
{
Console.Write(m);
return;
}
Console.Write(m + " ");
ShowNumbers(m + 1, n);
}
ShowNumbers(3, 17); 


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

internal static class ReverseArray 
{ 
    private static void Main(string[] args) 
    { 
        int[] num = {1, 7, 3, 0, 43, 37}; 
        ReverseArray.Reverse(num, num.Length - 1); 
    }
    public static void Reverse<T>(T[] array, int count) 
    { 
        if (count > 0) 
        { 
            Console.WriteLine(array[count]); 
            Reverse(array, count - 1); 
        } 
        else { Console.WriteLine(array[0]); }
    }
}
