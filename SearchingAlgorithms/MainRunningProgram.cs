using System;


public class MainRunningProgram
{
    public static void Main(string[] args)
    {
        // This is the main program that runs the binary search algorithm.
        // It creates an instance of the BinarySearch class and uses it to search for a value
        BinarySearch BinarySearch = new BinarySearch();
        int[] arrayOfIntegers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int searchValue = 10;
        int index = BinarySearch.Search(arrayOfIntegers, searchValue);
        if (index != -1)
        {
            Console.WriteLine($"Value {searchValue} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Value {searchValue} not found in the array.");
        }
        
    }   
}