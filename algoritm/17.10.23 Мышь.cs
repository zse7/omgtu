using System;
class Maus
{
    static void Main()
    {
        int sum = 0, p = 0;
        Console.WriteLine("Количество мышей:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Положение белой мыши:");
        int bel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Шаг:");
        int k = Convert.ToInt32(Console.ReadLine());
        int[] syr = new int[n];
        for (int i = 0; i < n; i++) syr[i] = i;
        for (int i = 0; i < n - 1; i++)
        {
            while (!((sum == k) && (syr[p] != -1)))
            {
                if (syr[p] != -1) sum = sum + 1;
                p = (p + 1) % n;
            }
            syr[p] = -1; sum = -1;
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            if (syr[i] != -1)
            {
                p = syr[i];
                break;
            }
        }
        if (bel - p < 0) Console.WriteLine($"Чтобы не поужинать белой мышью нужно начать с{n + (bel - p)}");
        else Console.WriteLine($"Чтобы не поужинать белой мышью нужно начать с{bel - p}");
    }
}