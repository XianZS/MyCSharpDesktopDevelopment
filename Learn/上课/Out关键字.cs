//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//// out关键字使用
////   out修饰的字段，允许在程序调用前被“未赋值”，而该被修饰的字段，允许在被调用函数中进行赋值，
//// 并且在调用函数中，也可以检测到该修饰字段被修改。
//namespace Learn.上课
//{
//    class Out关键字
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] nums = new int[10];
//            for(int i = 0; i < 10; i++)
//            {
//                nums[i]=random.Next(3,100);
//            }
//            int maxNum, minNum;
//            MyFind(out maxNum, out minNum, nums);
//            Console.WriteLine(maxNum);
//            Console.WriteLine(minNum);
//        }
//        static void MyFind(out int maxNum,out int minNum, int[] nums)
//        {
//            maxNum = 0;
//            minNum = 10000;
//            for (int i = 0; i < nums.Length; i++) {
//                maxNum = Math.Max(maxNum, nums[i]);
//                minNum = Math.Min(minNum, nums[i]);
//            }
//        } 
//    }
//}
