
Stack<string> stack = new Stack<string>();
int n = int.Parse(Console.ReadLine());
string text = string.Empty;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int arg = 0;
    //appends some String to the text and save in stack
    if (input[0] == "1")
    {
        stack.Push(text);
        text += input[1];
    }
    //erases the last count element form the text and save in stack
    else if (input[0] == "2")
    {
        stack.Push(text);
        arg = int.Parse(input[1]);
        text = text.Substring(0, text.Length - arg);
    }
    //erases the last element form the text
    else if (input[0] == "3")
    {
        arg = int.Parse(input[1]);
        Console.WriteLine(text[arg - 1]);
    }
    //undu the comands 1 and 2 
    else if (input[0] == "4")
    {
        text = stack.Pop();
    }
}
