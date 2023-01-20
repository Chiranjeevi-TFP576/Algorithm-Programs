namespace Algorithm_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5,3,2,6,9,1,4,8,7 };
            BubbleSort.BubbleSorting(arr);

            Console.WriteLine("Sorted array");
            BubbleSort.DisplayArray(arr);



        }
    }
}