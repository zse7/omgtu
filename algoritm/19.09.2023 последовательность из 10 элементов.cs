//максимальный элемент
using System;
class HelloWorld
{
    static void Main()
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 9; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b) a = b;
        }
        Console.WriteLine(a);
    }
}

//количество отрицательных
using System;
class HelloWorld
{
    static void Main()
    {
        int a, k = 0;
        for (int i = 1; i <= 9; i++)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0) k = k + 1;
        }
        Console.WriteLine(k);
    }
}

//сумма положительных элементов которые кратны 3
using System;
class HelloWorld
{
    static void Main()
    {
        int a, k = 0;
        for (int i = 1; i <= 9; i++)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                if (a % 3 == 0) k = k + a;
            }
        }
        Console.WriteLine(k);
    }
}

//минимальный элемент среди всех положительных
using System;
class HelloWorld
{
    static void Main()
    {
        int a, k;
        a = Convert.ToInt32(Console.ReadLine());
        k = Math.Abs(a);
        for (int i = 1; i <= 9; i++)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                if (a < k) k = a;
            }
        }
        Console.WriteLine(k);
    }
}

