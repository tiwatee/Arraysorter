namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedList = {100,2,4,1,38,18,34,22,10,63,12}; 
            //unsorted list.
            //Sorted:63,38,34,22,18,12,10,4,2,1
            Console.WriteLine("The unsorted list is [{0}]", string.Join(",", unsortedList));
            Sort sortedList = new Sort();
            int[] output = sortedList.SortedArray(unsortedList);
            Console.WriteLine("The sorted list is [{0}]", string.Join(",", output));
        }
    }

}