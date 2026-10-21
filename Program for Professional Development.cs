using System;

class Sort
{ //This is Divide and Conquer algorithm. So when the list is halved it is halved again to get just one integer itself to compare it with the other integers and then it is Merged back to the list
    private static void Merge(int[] arr, int[] left, int[] right) //the array and the splitted array left and right is noted here to be called in perameters
    {
        int leftint = 0, j = 0, k = 0; //declares the integers // i is known for the left side // j is known for the right side

        while (leftint < left.Length && j < right.Length) //while i is less than left length mod j is less than right side of the array
        {
            if (left[leftint] <= right[j]) //if left is less than or equal to right array
                arr[k++] = left[leftint++]; //make arr equal to left + 1
            else
                arr[k++] = right[j++]; //make arr equal to right + 1
        }

        while (leftint < left.Length) //while i is less than left length 
            arr[k++] = left[leftint++]; //make arr equal to left + 1

        while (j < right.Length) //while j is less than right length
            arr[k++] = right[j++]; //make array equal to right + 1
    }

    public static void MergeSort(int[] arr) //array is made noted in function
    {
        if (arr.Length <= 1) //if the array length is less that or equal to 1 then the program will return the sorted list
            return;

        int mid = arr.Length / 2; //divide and conquer 

        int[] left = new int[mid]; //this creates a new operator to change the name to find the middle of the list
        int[] right = new int[arr.Length - mid];

        for (int leftint = 0; leftint < mid; leftint++) //this is like a for i in range loop where it loops until i is smaller than 0
            left[leftint] = arr[leftint]; //makes left and array are the same

        for (int leftint = mid; leftint < arr.Length; leftint++) //loops for the length of the program
            right[leftint - mid] = arr[leftint]; //creates right to be sorted and be the same as arr

        MergeSort(left); //calls the left side of the split to be calculated
        MergeSort(right); //calls the right of the equation to be calculated

        Merge(arr, left, right); //calls the merge function to combine the two sides of the lists together
    }

        public static void Main()
    {
        int[] ints = { 1218, 9957, 1949, 5683, 2665, 5382, 1322, 9458, 4061, 8400, 6955, 1419, 8585, 211, 5299, 5600, 1414, 285, 9515, 5989, 3387, 7613, 3489, 8499, 9981, 1448, 8976, 2363, 564, 9481, 784, 800, 1018, 6613, 8448, 7591, 9561, 983, 1605, 8979, 4068, 4978, 4050, 3479, 5356, 8644, 3235, 438, 8417, 432, 4478, 1619, 2075, 66, 1912, 6749, 127, 9492, 5964,9854, 646, 3730, 2335, 2105, 6566, 3898, 7832, 8238, 5361, 4237, 7791, 1261, 7227, 8850, 9801, 9511, 9109, 5453, 8071, 65, 4590, 8377, 6805, 1060, 5293, 8673, 4219, 440, 6102, 9931, 2185, 2745, 6261, 9513, 2981, 491, 5477, 1426, 7276, 664, 5996, 6232, 5380, 4085, 1685, 9611, 6102, 431, 505, 8748, 5631, 2704, 8309, 702, 3741, 4178, 6896, 326, 932, 3854, 4567, 870, 3721, 1460, 2563, 8607, 5230, 2947, 5171, 6248, 1383, 3637, 1952, 1513, 2170, 2852, 3450, 3282, 3607, 8896 }; //arr ints is made in Main program

        Console.WriteLine("Original array:"); //outputs "original array"
        foreach (int leftint in ints) //for each integer output the ints in array this outputs integers without being changed into strings
        {
            Console.Write(leftint + " "); //prints integers in array 
        }
        Console.WriteLine(); //used for formatting
        Console.ReadLine(); //this is required to print the sorted array on the line below
        MergeSort(ints); //calls mergesort with array

        Console.WriteLine("Sorted array:"); //prints "sorted array"

        foreach (int leftint in ints) //for each integer in array
        {
            Console.Write(leftint + " "); //output integer
        }
        Console.WriteLine(); //used to format
        Console.ReadLine(); //this is required to allow me as the programmer to see it (due to Macbook issues)
        Console.WriteLine($"The largest number in the array is: { ints.Last()}"); //outputs the last and also biggest value in the array finding the largest number
    }
}
// Main is located at the end of the program so it can run back to the other functions and knows they are there
