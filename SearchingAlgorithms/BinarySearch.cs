using System;

class BinarySearch
{

    public int Search(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] == value)
            {
                return mid;
            }
            else if (array[mid] < value)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}