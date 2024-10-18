internal partial class Program
{
    private static void Main(string[] args)
    {
        PrintEvenNumbers(100);
    }

    public static void PrintEvenNumbers(int max)
    {
        int num = 2;
        while (num <= max)
        {
            Console.WriteLine($"{num}");
            num += 2;
        }
    }
}