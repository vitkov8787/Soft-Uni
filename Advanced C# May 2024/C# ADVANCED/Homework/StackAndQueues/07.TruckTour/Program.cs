using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());
//distance to the petrol station and amount of petrol
Queue<(int, int)> queue = new Queue<(int, int)>();
int c = 0;
for (int i = 0; i < n; i++)
{

    int[] inptut = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int km = inptut[0];
    int petrol = inptut[1];
    queue.Enqueue((km, petrol));
}
//1 km per 1l petrol

/*
l/km
1  5
10 3
3  4
*/
//dokato km < ot petrol
//zavyrtame reda
while (true)
{
    bool flag = true;
    int tottalPetrol = 0;

    foreach (var item in queue)
    {
        tottalPetrol += item.Item1;
        int km = item.Item2;
        tottalPetrol -= km;
        //if we have negative petrol we have to leave the for loop
        if (tottalPetrol < 0)
        {
            flag = false;
            break;
        }
    }
    //leave the while loop!
    if (flag)
    {
        break;
    }
    else
    {
        c++;
        queue.Enqueue(queue.Dequeue());
    }

}
Console.WriteLine(c);
