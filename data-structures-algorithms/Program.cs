

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] intArr = new int[] { 17, 3, 75, 202, 80 };
        int searchVal = 75;
        int valIndex = LinearSearch(intArr, searchVal);
        Console.WriteLine($"{searchVal} is {(valIndex == -1 ? "not found" : $"at index {valIndex}")}");
    }

    private static int LinearSearch(int[] intArr, int searchVal)
    {
        for (int index = 0; index < intArr.Length; index++)
        {
            if (intArr[index] == searchVal)
            {
                return index;
            }
            else if (intArr[index] > searchVal)
            {
                break;
            }
        }

        return -1;
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