int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for (int j = 0; j < numbers.Length; j++)
    {
        matrix[i, j] = numbers[j];

    }
}
int left = 0;
int right = 0;
for (int i = 0; i < size; i++)
{
    left += matrix[i, i];
}

for (int i = size - 1; i >= 0; i--)
{
    right += matrix[i, size - 1 - i];
}

System.Console.WriteLine($"{Math.Abs(left - right)}");