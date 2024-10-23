//namespace Learn
//{
//    class 静态方法
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("调用静态方法FuncBegin");
//            Console.Write("是否开始调用(是/否) : ");
//            string cho = Console.ReadLine();
//            if (FuncBegin(cho) == 'Y')
//                Console.WriteLine("调用成功");
//            else
//                Console.WriteLine("调用失败");
//            int[] nums = { 3, 8, 2, 5, 1, 4, 7, 9, 10, 5, 8, 6 };
//            Console.WriteLine("That nums max_number is " + maxNums(nums));
//            reNums(nums);
//            Console.WriteLine("nums[1] is " + nums[0]);
//        }
//        static char FuncBegin(string cho)
//        {
//            if (cho == "是")
//                return 'Y';
//            else 
//                return 'N';
//        }
//        static int maxNums(int[] nums)
//        {   // 寻找正整数数组中的最大数
//            int res = -1;
//            for (int i = 0; i < nums.Length; i++) res = Math.Max(res, nums[i]);
//            return res;
//        }
//        static int[] reNums(int[] nums)
//        {
//            nums[0] = 1;
//            return nums;
//        }
//    }
//}
