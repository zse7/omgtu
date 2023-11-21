using System;
class Dv
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("Введите количество строк:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        k = Convert.ToInt32(Console.ReadLine());
        int[,] da = new int[n, k];
        Console.WriteLine("Введите массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                da[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //1
        int cnt = 0;
        for (int i = 0; i < da.GetLength(0); i++)
        {
            int Max = da[i, 0];
            int Min = da[i, 0];
            for (int j = 0; j < da.GetLength(1); j++)
            {
                if (Max < da[i, j])
                {
                    Max = da[i, j];
                }
                if (Min > da[i, j])
                {
                    Min = da[i, j];
                }
            }
            if (Max % 2 == 0 && Min % 2 == 0)
            {
                cnt = cnt + 1;
            }
        }
        Console.WriteLine($"Количество строк в которых мин. и макс. элементы четные = {cnt}");
        //2
        Console.Write("Номера столбцов в которых все элементы положительные(начиная с нуля): ");
        for (int j = 0; j < da.GetLength(1); j++)
        {
            int c = 0;
            for (int i = 0; i < da.GetLength(0); i++)
            {
                if (da[i, j] >= 0)
                {
                    c = c + 1;
                }
            }
            if (c == n)
            {
                Console.Write(j);
            }
        }
        Console.WriteLine();
        //3
        int nul = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (da[i, j] == 0)
                {
                    nul = nul + 1;
                }
            }
        }
        Console.WriteLine($"Количество нулевых элементов во всем массиве = {nul}");
        //4
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < k; j++)
            {
                sum = sum + da[i, j];
            }
            if (sum == 0)
            {
                Console.WriteLine("Да,в массиве имеется строка с нулевой суммой");
                break;
            }
            else
            {
                Console.WriteLine("Нет,в массиве не имеется строка с нулевой суммой");
                break;
            }
        }

        //5
        int kolvo = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int chet = 0;
                int[] str1 = new int[k];
                int[] str2 = new int[k];
                for (int m = 0; m < k; m++)
                {
                    str1[m] = da[i, m];
                    str2[m] = da[j, m];
                }
                Array.Sort(str1);
                Array.Sort(str2);
                for (int m = 0; m < k; m++)
                {
                    if (str1[m] == str2[m])
                    {
                        chet += 1;
                    }
                }
                if (chet == k) kolvo += 1;
            }
        }
        Console.WriteLine($"Количество пар строк, состоящих из одинаковых элементов: {kolvo}");
    }
}