int m =int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double[,] array = new double [m,n];
Random rnd = new Random();
for (int i = 0; i < m;i++)
{
    for (int j=0; j<n;j++)
    { array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(-10, 10), 2);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}