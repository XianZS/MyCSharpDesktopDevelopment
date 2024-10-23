//namespace Learn
//{
//    class 条件判断
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please input number : ");
//            double num1 = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Please input number : ");
//            double num2 = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Please input \"+\" or \"-\" or \"*\" or \"/\" : ");
//            char cho = Convert.ToChar(Console.ReadLine());
//            double res;
//            if (cho == '+') res = num1 + num2;
//            else if (cho == '-') res = num1 - num2;
//            else if (cho == '*') res = num1 * num2;
//            else if (cho == '/') res = num1 / num2;
//            else res = -99999;
//            if (res != -99999) Console.WriteLine("Your need number is " + res);
//            else Console.WriteLine("Error!");
//        }
//    }
//}