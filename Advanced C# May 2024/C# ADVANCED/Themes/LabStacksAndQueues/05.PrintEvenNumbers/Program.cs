int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//Queue<int> queue = new Queue<int>();
Queue<int> queue = new Queue<int>(input);

var evenNUmbers = queue.Where(x => x % 2 == 0);
Console.WriteLine(string.Join(", ", evenNUmbers));