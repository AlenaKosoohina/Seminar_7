int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int k = -100;
int [,] array = { {1,4,7,2 },{5,9,2,3},{8,4,2,4 } };
//Random rnd = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if ((i == m) && (j == n)) { k = array[i, j]; }
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
if (k!=-100) { Console.WriteLine(k); }
else { Console.WriteLine("Такого числа нет"); }