
using System.Diagnostics;

namespace Learn
{
    class Program
    {
        // Code[1]
        //static void Main(string[] args)
        //{   // 基础运行
        //    Console.WriteLine("   /|\\");
        //    Console.WriteLine("  / | \\");
        //    Console.WriteLine(" /  |  \\");
        //    Console.WriteLine("/___|___\\");
        //    Console.ReadLine();
        //}

        // code[2]
        //static void Main(string[] args)
        //{   // 变量
        //    string Name = "jom";
        //    int Age = 32;
        //    Console.WriteLine("His name is " + Name);
        //    Console.WriteLine("His name is " + Name);
        //    Console.WriteLine("His age is " + Age);
        //}

        // code[3]
        //static void Main(string[] args)
        //{   // 基础数据类型
        //    // 字符串类型：string
        //    string phrase = "How are you?";
        //    // 字符类型：char
        //    char grade = 'A';
        //    // 整数类型：int
        //    int age = 32;
        //    // 小数类型：float,double,decimal
        //    double gpa = 3.3;
        //    // 布尔类型：bool:true/false
        //    bool isMale1 = true;
        //    bool isMale2 = false;
        //    Console.WriteLine(phrase);
        //    Console.WriteLine(grade);
        //    Console.WriteLine(age);
        //    Console.WriteLine(gpa);
        //    Console.WriteLine(isMale1);
        //    Console.Write(isMale2);
        //}
        //static void Main(string[] args)
        //{   // 字符串处理方法
        //    // 1、字符串方法
        //    string a = "Hello" + " World!";
        //    // 2、将字符串a转换为大写
        //    Console.WriteLine(a.ToUpper()); // HELLO WORLD
        //    // 3、查看字符串a是否包含某个子串，存在返回true，不存在返回false
        //    Console.WriteLine(a.Contains("orl")); // TRUE
        //    // 4、根据string的index返回内容
        //    Console.WriteLine(a[2]); // l
        //    // 5、匹配传入参数在目标对象中第一次出现的index，
        //    // 返回传入参数第一个元素所对应的index，存在返回index，不存在返回-1
        //    Console.WriteLine(a.IndexOf("W")); // 6
        //    Console.WriteLine(a.IndexOf("Z")); // -1
        //    // 6、将字符串a按照空格切分成数组，并返回index=0的内容
        //    Console.WriteLine(a.Split()[0]); // Hello
        //    // 7、切割字符串，取出字符串的某个子串，
        //    // 传入参数为(num1,num2),左闭右闭，num2可以省略，默认切割到末尾
        //    Console.WriteLine(a.Substring(2,4)); // oll
        //}
        //static void Main(String[] args)
        //{   // 数字操作
        //    int x = 3;
        //    int y = 5;
        //    double z = 3.3;
        //    double w = 5.0;
        //    Console.WriteLine(x * y);
        //    Console.WriteLine(x / y);
        //    Console.WriteLine(y % x);
        //    // 浮点数+整数=浮点数，数据类型向上兼容
        //    Console.WriteLine(z + w + x);
        //    // Math.Abs(num)对num取绝对值函数
        //    Console.WriteLine(Math.Abs(-2));
        //    // Math.Pow(num,k)对num取指数k函数
        //    Console.WriteLine(Math.Pow(3, 2)); // 9
        //    Console.WriteLine(Math.Pow(3.0, 2));
        //    Console.WriteLine("{0,4:N2}",9.0);
        //    Console.WriteLine("{0:F}",9.0);
        //    Console.WriteLine(Math.Pow(3.0, 2).GetType());
        //    Console.WriteLine(Math.Pow(3, 2).GetType());
        //    // Math.Sqrt(num)对num取平方根函数
        //    Console.WriteLine(Math.Sqrt(9.1));
        //    // Math.Max(num1,num2)取最大值函数
        //    Console.WriteLine(Math.Max(5, 4));
        //    // Math.Min(num1,num2)取最小值函数
        //    Console.WriteLine(Math.Min(3, 2));
        //    // Math.Round(num)对num进行四舍五入
        //    Console.WriteLine(Math.Round(4.3)); // 4
        //    Console.WriteLine(Math.Round(4.6)); // 5
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\t*********"+"字符串数据读入"+ "*********");
        //    Console.Write("请输入你的名字 : ");
        //    string name = Console.ReadLine();
        //    Console.Write("请输入你的年龄 : ");
        //    string age = Console.ReadLine();
        //    Console.WriteLine("Hello " + name + "\nYou are " + age);
        //}

        //static void Main(string[] args)
        //{   // 数据类型转换
        //    string num = "32";
        //    int number = Convert.ToInt32(num);
        //    Console.WriteLine(number);
        //}

        //static void Main(string[] args)
        //{
        //    // 输入整数、双精度浮点数
        //    Console.Write("请输入一个整数 : ");
        //    int numInt = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("请输入一个双精度浮点数 : ");
        //    double numDouble= Convert.ToDouble(Console.ReadLine());
        //    Console.Write("numInt is {0},numDouble is {1}",numInt, numDouble);
        //}

        //static void Main(string[] args)
        //{   // 游戏
        //    string color, pluralNoun, celebrity;
        //    Console.Write("Please input color : ");
        //    color = Console.ReadLine();
        //    Console.Write("Please input pluralNoun : ");
        //    pluralNoun = Console.ReadLine();
        //    Console.Write("Please input celebrity : ");
        //    celebrity = Console.ReadLine();
        //    Console.WriteLine("color is {0}\npluralNoun is {1}\ncelebrity is {2}",color,pluralNoun,celebrity);
        //}

        //static void Main(string[] args)
        //{
        //    // C sharp语法格式: type [] nameList = { child_1, child_2, child_3};
        //    Console.WriteLine("·数组_整数数组操作_intNums");
        //    int[] nums = { 4, 8, 15, 16, 23, 42 };
        //    // index from 0 to nums.length-1,for example:
        //    Console.WriteLine(nums[2]); // 15
        //    // Gave num to nums[index]
        //    int number = nums[1];
        //    nums[1] = 1;
        //    Console.WriteLine("{0} change to {1}", number, nums[1]);
        //    Console.WriteLine("·数组_字符串数组操作_stringNums");
        //    string[] friends = new string[5];
        //    Console.WriteLine("Please write five names:");
        //    for(int i = 0; i < 5; i++) {
        //        Console.Write("This is {0} name : ", i + 1); 
        //        friends[i] = Console.ReadLine(); 
        //    }
        //    Console.Write("There are ");
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Write("{0}", friends[i]);
        //        if (i != 4) Console.Write("、");
        //        else Console.WriteLine();
        //    }
        //    Console.WriteLine("请输入一组数字，每个数字之间由空格分隔");
        //    string[] news = Console.ReadLine().Split();
        //    for (int i = 0; i < news.Length; i++) Console.Write(news[i]+" ");
        //}

        //static void Main(string[] args) { 
        //    Console.WriteLine("Ends");
        //}
    }
}