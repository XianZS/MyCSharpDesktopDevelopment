//using System.Xml.Serialization;

//namespace Learn
//{
//    class 继承
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Learn");
//            Dad some1 = new Dad();
//            Me some2 = new Me();
//            Dad some3 = new Me();
//            Console.WriteLine(some1.Pr());
//            Console.WriteLine(some2.Pr());
//            Console.WriteLine(some3.Pr());
//        }
//    }
//    class Dad
//    {
//        public virtual bool Pr()
//        {
//            try
//            {
//                Console.WriteLine("我是你爷");
//                return true;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("ERROR:{0}", e);
//                return false;
//            }
//        }
//    }
//    class Me : Dad
//    {
//        public override bool Pr()
//        {
//            try
//            {
//                Console.WriteLine("我是你爹");
//                return true;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                return false;
//            }
//        }
//    }
//}