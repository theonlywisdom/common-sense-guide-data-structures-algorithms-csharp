internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array1 = { 1, 3, 5, 7 };
        int[] array2 = { 2, 4, 6, 8 };

        int[] mergedArray = MergeTwoSortedArrays(array1, array2);

        foreach (var item in mergedArray)
        {
            Console.WriteLine(item);
        }
    }

    public static int[] MergeTwoSortedArrays(int[] array1, int[] array2)
    {
        int[] mergedList = new int[array1.Length + array2.Length];

        int array1Pointer = 0;
        int array2Pointer = 0;
        int mergedPointer = 0;

        while (array1Pointer < array1.Length
            || array2Pointer < array2.Length)
        {
            if (array1Pointer >= array1.Length)
            {
                mergedList[mergedPointer] = array2[array2Pointer];
                array2Pointer++;
            }
            else if (array2Pointer >= array2.Length)
            {
                mergedList[mergedPointer] = array1[array1Pointer];
                array1Pointer++;
            }
            else if (array1[array1Pointer] < array2[array2Pointer])
            {
                mergedList[mergedPointer] = array1[array1Pointer];
                array1Pointer++;
            }
            else
            {
                mergedList[mergedPointer] = array2[array2Pointer];
                array2Pointer++;
            }
            mergedPointer++;
        }

        return [.. mergedList];
    }

    private static bool FindNeedle(string needle, string haystack)
    {
        int needleIndex = 0;
        int haystackIndex = 0;
        bool isFound = false;

        while (haystackIndex < haystack.Length)
        {
            if (needle[needleIndex] == haystack[haystackIndex])
            {
                isFound = true;
                while (needleIndex < needle.Length)
                {
                    if (needle[needleIndex] != haystack[haystackIndex + needleIndex])
                    {
                        isFound = false;
                        break;
                    }
                    needleIndex++;
                }
                if (isFound)
                {
                    return true;
                }
                needleIndex = 0;
            }
            haystackIndex++;
        }
        return false;
    }

    private static bool SumArray100(int[] intArr)
    {
        int leftIndex = 0;
        int rightIndex = intArr.Length - 1;
        while (leftIndex < intArr.Length / 2)
        {
            if (intArr[leftIndex] + intArr[rightIndex] != 100)
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }

    private static int[] TwoNumberProducts(int[] vals)
    {
        List<int> products = new List<int>();

        for (int i = 0; i < vals.Length - 1; i++)
        {
            for (int j = i + 1; j < vals.Length; j++)
            {

                products.Add(vals[i] * vals[j]);
            }
        }
        return products.ToArray();
    }

    private static bool IsPalindrome(string word)
    {
        int leftIndex = 0;

        int rightIndex = word.Length - 1;

        while (leftIndex < word.Length / 2)
        {
            if (word[leftIndex] != word[rightIndex])
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }

        return true;
    }

    private static int CountOnes(int[][] jaggedArr)
    {
        int count = 0;

        foreach (int[] innerArr in jaggedArr)
        {
            foreach (var item in innerArr)
            {
                if (item == 1)
                {
                    count += 1;
                }
            }
        }

        return count;
    }

    private static string[] MarkInventory(string[] clothesArr)
    {
        List<string> clothingOptions = new List<string>();
        foreach (string item in clothesArr)
        {
            for (int i = 1; i < 6; i++)
            {
                clothingOptions.Add($"{item} Size: {i}");
            }
        }

        return clothingOptions.ToArray();
    }

    private static double AverageCelsius(double[] tempsFahr)
    {
        List<double> celsiusTemps = new List<double>();
        foreach (var val in tempsFahr)
        {
            double celsiusConv = (val - 32) / 1.8;
            celsiusTemps.Add(celsiusConv);
        }

        double sumOfcelsiusTemps = 0;

        foreach (var val in celsiusTemps)
        {
            sumOfcelsiusTemps += val;
        }

        return sumOfcelsiusTemps / celsiusTemps.Count;
    }

    private static string[] WordBuilder(char[] chars)
    {
        List<string> collection = new List<string>();
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                collection.Add($"{chars[i]}{chars[j]}");
            }
        }

        return collection.ToArray();
    }

    private static int AverageOfEvenNumbers(int[] intArr1)
    {
        int sumOfEvenNums = 0;
        int countOfEvenNums = 0;

        for (int i = 0; i < intArr1.Length; i++)
        {
            if (intArr1[i] % 2 == 0)
            {
                sumOfEvenNums += intArr1[i];
                countOfEvenNums++;
            }
        }

        return sumOfEvenNums / countOfEvenNums;
    }

    private static int[] GetArrayIntersection(int[] intArr1, int[] intArr2)
    {
        HashSet<int> set1 = new HashSet<int>(intArr1);
        List<int> arrayIntersect = new List<int>();

        for (int i = 0; i < intArr2.Length; i++)
        {
            if (!set1.Add(intArr2[i]))
            {
                arrayIntersect.Add(intArr2[i]);
            }
        }
        return arrayIntersect.ToArray();
    }

    private static int[] InsertionSort(int[] intArr)
    {
        for (int index = 1; index < intArr.Length; index++)
        {
            int tempValue = intArr[index];
            int position = index - 1;

            while (position >= 0)
            {
                if (intArr[position] > tempValue)
                {
                    intArr[position + 1] = intArr[position];
                    position = position - 1;
                }
                else
                {
                    break;
                }
            }

            intArr[position + 1] = tempValue;
        }

        return intArr;
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