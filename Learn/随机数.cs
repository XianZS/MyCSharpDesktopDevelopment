//namespace Learn
//{
//    class 随机数
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("nums1原序列:");
//            int[] nums1 = CreateRandomList(10);
//            Console.Write("\nnums1排序之后的序列:");
//        }
//        static int Compare(int a, int b)
//        {
//            return a > b ? a : b;
//        }
//        static int[] CreateRandomList(int L)
//        {
//            Random random = new Random();
//            int[] res = new int[L];
//            for (int i = 0; i < L; i++)
//            {
//                res[i] = random.Next(100);
//                Console.Write("{0} ", res[i]);
//            }
//            return res;
//        }
//    }
//}