int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
char[,] matrix = new char[size[0], size[1]];


string input = Console.ReadLine();

int counter = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0)
        {
            //от ляво на дясно докато има място
            matrix[i, j] = input[counter++];
            //!!!! само когато стигне 0
            if (counter == input.Length)
            {
                counter = 0;
            }
        }
        else
        {
            //от дясно на ляво докато има място
            matrix[i, matrix.GetLength(1) - 1 - j] = input[counter++];
            //!!!! само когато стигне 0
            if (counter == input.Length)
            {
                counter = 0;
            }
        }
    }
}

//print matrix

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}