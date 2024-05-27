int n = int.Parse(Console.ReadLine());
int[][] matrix = new int[n][];
matrix[0] = new int[1] { 1 };

//i =ред//индекс , j=стойност

for (int i = 1; i < n; i++)
{
    matrix[i] = new int[i + 1];

    for (int j = 0; j < matrix[i].Length; j++)
    {
        if (j < matrix[i - 1].Length)
        {
            matrix[i][j] = matrix[i - 1][j];
        }
        if (j > 0)
        {
            matrix[i][j] += matrix[i - 1][j - 1];
        }


    }
}

//print matrix
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}




