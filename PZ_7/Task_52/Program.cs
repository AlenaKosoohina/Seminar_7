using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m, n];
double[] sum = new double[n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое по столбцам");
for (int j=0; j < n; j++)
{
    for (int i=0;i<m; i++)
    {
    sum[j] = sum[j] + array[i, j];
    }
    sum[j] = Math.Round((sum[j] / m),2);
Console.Write($"{sum[j]} ");
}
