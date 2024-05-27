int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int i = 0; i < rows; i++)
{
    matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}

// analyzing the matrix

for (int i = 0; i < matrix.Length - 1; i++)
{
    if (matrix[i].Length == matrix[i + 1].Length)
    {

        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] *= 2;
            matrix[i + 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] /= 2;

        }
        for (int j = 0; j < matrix[i + 1].Length; j++)
        {

            matrix[i + 1][j] /= 2;
        }
    }
}
//interact with the matrix with commands
string command = Console.ReadLine();
while (command != "End")
{
    string[] arg = command.Split(' ');
    int tRow = int.Parse(arg[1]);
    int tCol = int.Parse(arg[2]);
    int value = int.Parse(arg[3]);
    if (IsInside(matrix, tRow, tCol))
    {
        if (arg[0] == "Add")
        {
            matrix[tRow][tCol] += value;
        }
        else if (arg[0] == "Subtract")
        {
            matrix[tRow][tCol] -= value;
        }
    }
    command = Console.ReadLine();
}

for (int i = 0; i < matrix.Length; i++)
{
    Console.WriteLine(string.Join(" ", matrix[i]));
}

static bool IsInside(int[][] board, int row, int col)
{
    return row >= 0 && row < board.Length && col >= 0 && col < board[row].Length;
}