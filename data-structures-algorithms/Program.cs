﻿


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] intArr = new int[] { 3, 17, 75, 80, 202 };
        int searchVal = 3;
        int valIndex = BinarySearch(intArr, searchVal);
        Console.WriteLine($"{searchVal} is {(valIndex == -1 ? "not found" : $"at index {valIndex}")}");
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