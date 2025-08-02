// See https://aka.ms/new-console-template for more information

static void Main(string[] args=null)
{
    int total = 0;
    for (int i = 1; i <= 10; i++)
    {
        total += i;
    }

    Console.WriteLine($"1+2+..+10={total}");
}

Main();