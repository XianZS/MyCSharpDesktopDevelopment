////using System.Runtime.InteropServices;
//namespace Learn
//{
//    class 继承
//    {
//        class Chef
//        {
//            public void MakeChicken()
//            {   // 制作火鸡
//                Console.WriteLine("MakeChicken");
//            }
//            public void MakeSalalad()
//            {   // 制作沙拉
//                Console.WriteLine("MakeSalalad");
//            }
//            public virtual void MakeChickenSalalad()
//            {   // 当类中的方法加上“virtual”关键字时，它将允许被子类重写
//                Console.WriteLine("I don't know to do somethings.");
//            }
//        }
//        class MaxChef : Chef
//        {
//            // MaxChef继承Chef，可以理解为MaxChef是Chef的儿子(继承)，并且MaxChef学会了Chef所有的功能(继承了它的全部属性和方法)
//            public override void MakeChickenSalalad()
//            {
//                Console.WriteLine("I know how to do it.");
//            }
//        }
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("继承");
//            /* --- 炊事班 --- */
//            // 初始化炊事班
//            Chef chef = new Chef();
//            // 炊事班调用
//            chef.MakeChicken();
//            chef.MakeSalalad();
//            chef.MakeChickenSalalad();
//            /* --- 高级炊事班(它继承自炊事班) --- */
//            // 初始化高级炊事班
//            MaxChef maxChef = new MaxChef();
//            // 高级炊事班调用
//            maxChef.MakeChickenSalalad();
//        }
//    }
//}