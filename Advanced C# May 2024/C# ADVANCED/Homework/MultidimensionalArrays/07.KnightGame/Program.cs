
int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
    }
}

int kingsRemove = 0;
while (true)
{
    int rowPos = 0;
    int colPos = 0;
    int kils = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int atak = 0;

            if (matrix[i, j] != 'K')
            {
                continue;
            }
            //logic for moving the fucking knight when we itterate through the matrix

            atak = NewMethod(matrix, i, j, atak);
            if (atak > kils)
            {
                kils = atak;
                rowPos = i;
                colPos = j;
            }
        }
    }
    if (kils > 0)
    {
        matrix[rowPos, colPos] = '0';
        kingsRemove++;
    }
    else
    {
        break;
    }
}
System.Console.WriteLine(kingsRemove);

static bool IsInside(char[,] board, int row, int col)
{
    return row >= 0 && row < board.GetLength(0)
        && col >= 0 && col < board.GetLength(1);
}

static int NewMethod(char[,] matrix, int i, int j, int atak)
{
    if (IsInside(matrix, i - 2, j + 1) && matrix[i - 2, j + 1] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i - 1, j + 2) && matrix[i - 1, j + 2] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i + 1, j + 2) && matrix[i + 1, j + 2] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i + 2, j + 1) && matrix[i + 2, j + 1] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i + 2, j - 1) && matrix[i + 2, j - 1] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i + 1, j - 2) && matrix[i + 1, j - 2] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i - 1, j - 2) && matrix[i - 1, j - 2] == 'K')
    {
        atak++;
    }

    if (IsInside(matrix, i - 2, j - 1) && matrix[i - 2, j - 1] == 'K')
    {
        atak++;
    }

    return atak;
}