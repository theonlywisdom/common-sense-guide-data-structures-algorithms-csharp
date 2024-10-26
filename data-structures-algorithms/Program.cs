internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] intArr = new int[] { 4, 2, 7, 1, 3 };
        int[] sortedArray = SelectionSort(intArr);

        foreach (int val in sortedArray)
        {
            Console.WriteLine(val);
        }

    }

    private static int[] SelectionSort(int[] intArr)
    {
        for (int i = 0; i < intArr.Length - 1; i++)
        {
            int lowestNumIndex = i;
            for (int j = i + 1; j < intArr.Length; j++)
            {
                if (intArr[j] < intArr[lowestNumIndex])
                {
                    lowestNumIndex = j;
                }
            }

            if (lowestNumIndex != i)
            {
                int tempValAtIndex = intArr[i];
                intArr[i] = intArr[lowestNumIndex];
                intArr[lowestNumIndex] = tempValAtIndex;
            }
        }

        return intArr;
    }

    private static int FindGreatestNumber(int[] intArr)
    {
        int greatestNumber = intArr[0];
        for (int i = 0; i < intArr.Length; i++)
        {
            if (intArr[i] > greatestNumber)
            {
                greatestNumber = intArr[i];
            }
        }
        return greatestNumber;
    }

    private static bool HasDuplicateValue(int[] intArr)
    {
        HashSet<int> existingNumbers = new HashSet<int>();

        for (int i = 0; i < intArr.Length; i++)
        {
            if (!existingNumbers.Add(intArr[i]))
            {
                return true;
            }
        }

        return false;
    }

    private static int[] BubbleSort(int[] intArr)
    {
        int unsortedUntilIndex = intArr.Length - 1;
        bool sorted = false;

        while (!sorted)
        {
            sorted = true;
            for (int i = 0; i < unsortedUntilIndex; i++)
            {
                if (intArr[i] > intArr[i + 1])
                {
                    int tempValAtI = intArr[i];
                    intArr[i] = intArr[i + 1];
                    intArr[i + 1] = tempValAtI;
                    sorted = false;
                }
            }
            unsortedUntilIndex -= 1;
        }
        return intArr;
    }

    private double MedianOfOrderedArray(int[] valArray)
    {
        int middleIndex = valArray.Length / 2;


        if (valArray.Length % 2 == 0)
        {
            return (valArray[middleIndex - 1] + valArray[middleIndex]) / 2;
        }
        else
        {
            return valArray[middleIndex];
        }
    }

    private string[] SelectAStrings(string[] strArray)
    {
        List<string> strList = new();
        foreach (string str in strArray)
        {
            if (str.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                strList.Add(str);
            }
        }

        return [.. strList];
    }

    private int ChessboardSpace(int numOfGrains)
    {
        int chessboardSpaces = 0;
        int placedGrains = 0;

        while (placedGrains < chessboardSpaces)
        {
            placedGrains *= 2;
            placedGrains++;
        }

        return chessboardSpaces;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 100 == 0) ? (year % 400 == 0) : (year % 4 == 0);
    }

    private static int BinarySearch(int[] intArr, int searchVal)
    {
        int lowerBound = 0;
        int upperBound = intArr.Length - 1;

        while (lowerBound < upperBound)
        {
            int midPoint = (lowerBound + upperBound) / 2;
            int valAtMidPoint = intArr[midPoint];

            if (searchVal == valAtMidPoint)
            {
                return midPoint;
            }
            else if (searchVal < valAtMidPoint)
            {
                upperBound = midPoint - 1;
            }
            else if (searchVal > valAtMidPoint)
            {
                lowerBound = midPoint + 1;
            }
        }

        return -1;
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