//namespace Learn
//{
//    class 异常处理
//    {
//        static void Main(string[] args)
//        {
//            try
//            {   // This code maybe error.
//                Console.Write("请输入一个数字 : ");
//                int x = Convert.ToInt32(Console.ReadLine());
//                Console.Write("请输入另一个数字 : ");
//                int y = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine(x / y);
//            }
//            catch(Exception e)
//            {
//                // Printf error .
//                Console.WriteLine(e);
//            }
//            finally
//            {
//                // This code Always run .
//                Console.WriteLine("Debug ends!");
//            }
//        }
//    }
//}