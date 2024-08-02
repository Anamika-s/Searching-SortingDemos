namespace SortingDemos
{
    internal class Program
    {
        static int[] num = [2, 4, 5, 10, 12, 20, 9, 30, 89];

        static void Main(string[] args)
        {
            Console.WriteLine("Original Array");
            DisplayElements();
            //SelectionSort();
            BubbleSort();
            Console.WriteLine("after sort");
            DisplayElements();
        }
        static void DisplayElements()
        {
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }

        static void SelectionSort()
        {
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)

                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }

            }

        }
        static void BubbleSort()
        {
            int n = num.Length;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        // swap elements
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort()
        {
            int x, j = 0;
            for(int i=0;i<num.Length; i++)
            {
                x = num[i];
                j = i - 1;
                while(j>=0 && num[j]>x)
                {
                    num[j + 1] = num[j];
                    j = j - 1;
                }
                num[j+1] = x;
            }
            
        }

















    }
}