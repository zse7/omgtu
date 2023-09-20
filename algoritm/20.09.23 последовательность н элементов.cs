//наименьшая длинна подпоследовательности, состоящих из одинаковых элементов
using System;
class HelloWorld
{
    static void Main()
    {
        int n, min_sub, cur_sub = 1, number, prv_number;  //кол-во элементов, минимальная длина, длина текущей послeдовательности, текущее число, предыдущее число
        n = Convert.ToInt32(Console.ReadLine());
        min_sub = n;
        prv_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == prv_number)
            {
                cur_sub++;

            }
            else
            {
                if ((min_sub > cur_sub) & (cur_sub > 1))
                {
                    min_sub = cur_sub;

                }
                cur_sub = 1;
            }
            prv_number = number;
        }
        Console.WriteLine(min_sub);
    }
}

//все ли элементы кратны номеру под которым они считываются
using System;
class HelloWorld
{
    static void Main()
    {
        int n, k;
        int count = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            if (k % i != 0)
            {
                count++;
            }
        }
        Console.WriteLine(count == 0);
    }
}

//максимальная длинна подпоследовательности, состоящих из различных элементов
using System;
class HelloWorld
{
    static void Main()
    {
        int n, max_sub, cur_sub = 1, number, prv_number;  //кол-во элементов, max длина, длина текущей послндовательности, текущее число, предыдущее число
        n = Convert.ToInt32(Console.ReadLine());
        max_sub = 1;
        prv_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number != prv_number)
            {
                cur_sub++;

            }
            else
            {
                if ((max_sub < cur_sub) & (cur_sub > 1))
                {
                    max_sub = cur_sub;

                }
                cur_sub = 1;
            }
            prv_number = number;
        }
        Console.WriteLine(max_sub);
    }
}

//образует ли заданная последовательностьравномерно убывающую последовательность
int n, number, pr_number, difference, switcher = 1; //кол-во элементов, текущее число, предыдущее число, разница, переключатель
n = Convert.ToInt32(Console.ReadLine());
pr_number = Convert.ToInt32(Console.ReadLine());
number = Convert.ToInt32(Console.ReadLine());
difference = pr_number - number;
if (difference > 0)
{
    for (int i = 0; i < n - 2; i++)
    {
        pr_number = number;
        number = Convert.ToInt32(Console.ReadLine());
        if ((pr_number - number) != difference)
        {
            switcher = 0;
        }
    }
}
else
{
    switcher = 0;
}
if (switcher == 1)
{
    Console.WriteLine("Последовательность является равномено убывающей");
}
else
{
    Console.WriteLine("Последовательность не является равномено убывающей");
}