

int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];
for (int i = 0; i < rows; i++)
{
    matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}

string[] command = Console.ReadLine().Split().ToArray();
while (command[0] != "END")
{
    if (command[0] == "Add")
    {
        int rowAdd = int.Parse(command[1]);
        int colAdd = int.Parse(command[2]);
        int valueAdd = int.Parse(command[3]);
        if (rowAdd >= 0 && rowAdd < matrix.Length && colAdd >= 0 && colAdd < matrix[rowAdd].Length)
        {
            matrix[rowAdd][colAdd] += valueAdd;
        }
        else System.Console.WriteLine("Invalid coordinates");
    }
    if (command[0] == "Subtract")
    {
        int rowSub = int.Parse(command[1]);
        int colSub = int.Parse(command[2]);
        int valueSub = int.Parse(command[3]);
        if (rowSub >= 0 && rowSub < matrix.Length && colSub >= 0 && colSub < matrix[rowSub].Length)
        {
            matrix[rowSub][colSub] -= valueSub;
        }
        else System.Console.WriteLine("Invalid coordinates");
    }
    command = Console.ReadLine().Split().ToArray();
}

for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}