//количество элементов значение которых больше предыдущего
using System;
class HelloWorld
{
    static void Main()
    {
        int n, pr_num, num, ch = 0;
        n = Convert.ToInt32(Console.ReadLine());
        pr_num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num > pr_num)
            {
                ch++;
            }
        }
        Console.WriteLine(ch);
    }
}

//определить количество элементов значение которых меньше всех вводимых до него
using System;
class Posledovatelnost_n
{
    static void Main()
    {
        int n, x, y, min_el, ch = 0;
        n = Convert.ToInt32(Console.ReadLine());
        x = Convert.ToInt32(Console.ReadLine());
        min_el = x;
        for (int i = 1; i < n; i++)
        {
            y = Convert.ToInt32(Console.ReadLine());
            if (y < min_el)
            {
                ch++;
                min_el = y;
            }
        }
        Console.WriteLine(ch);
    }
}

//Определить количество элементов значение которых больше левого и правого эдемента
using System;
class HelloWorld
{
    static void Main()
    {
        int n, pr_num, num, sl_num, ch = 0;
        n = Convert.ToInt32(Console.ReadLine());
        pr_num = Convert.ToInt32(Console.ReadLine());
        num = Convert.ToInt32(Console.ReadLine());
        sl_num = Convert.ToInt32(Console.ReadLine());
        if ((num > pr_num) & (num > sl_num)) ch++;
        for (int i = 1; i < n - 2; i++)
        {
            pr_num = num;
            num = sl_num;
            sl_num = Convert.ToInt32(Console.ReadLine());
            if ((num > pr_num) & (num > sl_num)) ch++;
        }
        Console.WriteLine(ch);
    }
}

//Определить наибольшую длинну возрастающей подпоследовательности
using System;
class HelloWorld
{
    static void Main()
    {
        int n, x, y, max = 1, cnt = 1;
        n = Convert.ToInt32(Console.ReadLine());
        x = Convert.ToInt32(Console.ReadLine()); 
        for (int i = 1; i < n; i++)
        {
            y = Convert.ToInt32(Console.ReadLine());
            if (y > x)
            {
                cnt++;
            }
            else if (cnt > max)
            {
                max = cnt;
                cnt = 1;
            }
            x = y;
        }
        Console.WriteLine(max);
    }
}
