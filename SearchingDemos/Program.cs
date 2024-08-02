namespace SearchingDemos
{
    internal class Program
    {
        static int[] num = [2, 4, 5, 10, 12, 20, 9, 30, 89];

        static void Main(string[] args)
        {
            Console.WriteLine("enter element to search");
            int x = byte.Parse(Console.ReadLine());
            //bool found = LinearSearch(x);
            bool found = BinarySearch(x);
            // unary operator  ++ --  n++
            /// binary operator   + -  9+7
            //if (found == true) Console.WriteLine("element found");
            //else Console.WriteLine("element not found");
            // ?:  // conditional / ternary operator
            Console.WriteLine(found == true ? "element found" : "element not found") ;
        }
        static bool LinearSearch(int x)
        {
            bool flag = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == x)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static bool BinarySearch(int x)
        {
            Array.Sort(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            bool flag = false;
            int low = 0;
            int high = num.Length - 1;
            int mid = (low + high) / 2;
            while (low <= high)
            {
                if (num[mid] == x)
                {
                    flag = true;
                    break;
                }
                else if (x < num[mid])
                {
                    high = mid - 1;
                }
                else if (x > num[mid])
                {
                    low = mid + 1;
                }
                mid = (low + high) / 2;
            }

            return flag;


            }
    }
}
