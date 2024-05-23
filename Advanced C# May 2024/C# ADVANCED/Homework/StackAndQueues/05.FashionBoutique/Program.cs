//get array
int[] order = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//amount
int rackCapacity = int.Parse(Console.ReadLine());
//put order in the stack
Stack<int> rack = new Stack<int>(order);
int sum = 0;
//start with one box/ rack....!
int count = 1;
//logic
//until we have something in stack
while (rack.Any())
{
    int pop = rack.Pop();

    if (sum + pop <= rackCapacity)
    {
        sum += pop;
    }
    else
    {
        //sum =  the last one we try
        sum = pop;
        //whe count for racks
        count++;
    }
}

//needet racks/boox /shaft/ kubche 
System.Console.WriteLine(count);
