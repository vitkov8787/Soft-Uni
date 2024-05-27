int[] size = Console.ReadLine().Split(' ')
.Select(int.Parse)
.ToArray();

string[,] matrix = new string[size[0], size[1]];


for (int i = 0; i < size[0]; i++)
{
    string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = elements[j];
    }
}
string command = Console.ReadLine();

while (command != "END")
{

    string[] arg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string action = arg[0];
    if (action != "swap" || arg.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine();
        continue;
    }

    int row1 = int.Parse(arg[1]);
    int col1 = int.Parse(arg[2]);
    int row2 = int.Parse(arg[3]);
    int col2 = int.Parse(arg[4]);


    if (!IsTrue(matrix, row1, col1) || !IsTrue(matrix, row2, col2))
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine();
        continue;
    }

    //swap rows and cols
    string temp = matrix[row1, col1];
    //a b c; 
    //a=2;b=3=;c=0;=>
    //c=a(2);a=b(3);b=c(2);
    //a=3,b=2,c=3
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = temp;

    //print new matrix

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    command = Console.ReadLine();
}

static bool IsTrue(string[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0)
    && col >= 0 && col < matrix.GetLength(1);
}