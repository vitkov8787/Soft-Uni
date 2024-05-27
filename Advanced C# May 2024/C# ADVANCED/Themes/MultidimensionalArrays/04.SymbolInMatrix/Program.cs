/*
3
ABC
DEF
X!@
!
*/

int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];

for (int i = 0; i < size; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = line[j];
    }
}
char search = char.Parse(Console.ReadLine());
bool flag = false;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (matrix[i, j] == search)
        {
            Console.WriteLine($"({i}, {j})");
            flag = true;
            break;
        }
    }

    if (flag) break;
}
if (flag == false)
{
    Console.WriteLine($"{search} does not occur in the matrix");
}