namespace Algorithm_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Problems");
            bool end = true;
            Console.WriteLine("1.BubbleSort\n2.Binary Search\n3.InsertionSort\n4.PrimeNumber\n5PrimeVsAnagram\n6.End Of Programme");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int[] arr = { 5, 3, 2, 6, 9, 1, 4, 8, 7, 10 };
                        BubbleSort.BubbleSorting(arr);

                        Console.WriteLine("Sorted array");
                        BubbleSort.DisplayArray(arr);
                        break;
                    case 2:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"D:\Batch 244\Algorithm-Programs\Algorithm_Problems\BinarySearch.txt");
                        break;
                    case 3:
                        InsertionSort.Insertion();
                        break;
                    case 4:
                        PrimeNumber.CheckPrime();
                            break;
                    case 5:
                        PalinedromeVsAnagram palindrome = new PalinedromeVsAnagram();
                        palindrome.Anagram();
                        palindrome.PrimeNumber();
                        palindrome.PalindromeNum();
                        break;
                    case 6:
                        end = false;
                        break;

                    default:
                        Console.WriteLine("You choose Invalid Option");
                        break;


                }
            }

            

            


        }
    }
}