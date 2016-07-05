namespace BinarySearch
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Binary Search - O(log n) performance and O(1) space
        /// Search algorithm that finds the position of a target value.
        /// This begins by comparing the middle of the array with the search value, 
        /// if the search value matches the middle element, return the position in the array
        /// If the target value is less than the middle element, the search continues the lower 
        /// half or if the search value is more, the search continues the upper half respectively
        /// this efficiently eliminates half of the array  from consideration
        /// </summary>        
        /// <param name="array">Sorted Array</param>
        /// <param name="searchValue">Search Value</param>
        public static int BinarySearch(this int[] array, int searchValue)
        {
            int low = 0;
            int high = array.Length - 1;
            int midPoint = 0;
            while (low <= high)
            {
                //get mid point of array
                midPoint = (high + low) / 2;      

                if (searchValue == array[midPoint])
                {
                    return midPoint;
                }
                else if (searchValue < array[midPoint])
                {
                    //set high to the middle and search lower hald
                    high = midPoint - 1;
                }
                else
                {
                    //set low to the middle and search upper half
                    low = midPoint + 1;
                }
            }

            return -1; //item not found

        }

    }
}
