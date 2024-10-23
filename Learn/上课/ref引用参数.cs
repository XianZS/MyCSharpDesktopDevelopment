//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn.上课
//{
//    class ref引用参数
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 20;
//            New make = new New();
//            make.Make(ref a, ref b);
//            Console.WriteLine(a + b);
//        }
//    }
//    class New
//    {
//        public void Make(ref int a, ref int b)
//        {
//            a = 1;
//            b = 2;
//        }
//    }
//}