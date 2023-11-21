using System;
class Professional
{
    static void Main()
    {
        while (true)
        {
            int sum = -1, p = 0;
            bool flag = false;
            Console.WriteLine("Укажите кол-во серых мышей");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во белых мышей");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Через сколько съедается мышь");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться серых");
            int o1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться белых");
            int o2 = Convert.ToInt32(Console.ReadLine());
            int ms = n1 - o1;
            int[] syr = new int[n1 + n2];
            for (int i = 0; i < n1 + n2; i++) syr[i] = i;
            for (int i = 0; i < (n1 + n2) - (o2 + o1); i++)
            {
                while (!((sum == k) && (syr[p] != -1)))
                {
                    if (syr[p] != -1) sum += 1;
                    if ((sum != k) || (syr[p] == -1)) p = (p + 1) % (n2 + n1);
                }
                syr[p] = -1; sum = 0;
            }

            Console.WriteLine();
            for (int i = 0; i < n1 + n2; i++)
            {

                if ((n1 < o1) || (n2 < o2))
                {
                    flag = true; break;
                }

                if (syr[i] == -1)
                {
                    if (ms != 0)
                    {
                        ms += -1;
                        Console.WriteLine($"Расположим серую(м) мышь на {i + 1} месте");

                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположим белую(м) мышь на {i + 1} месте");
                    }

                }
                else
                {
                    if (o1 != 0)
                    {
                        o1 += -1;
                        Console.WriteLine($"Расположим серую(ж) мышь на {i + 1} месте");

                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположим белую(ж) мышь на {i + 1} месте");
                    }
                }
            }
            if (flag) Console.WriteLine("Расположить не возможно");
            Console.WriteLine();
        }
    }
}
