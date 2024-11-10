using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpDesktopDevelopment
{
    public class MyClass
    {
        // 单例模式
        // 类中定义静态变量
        private static MyClass _Instance=null;
        public static MyClass Instance
        {
            get
            {
                // 第一次使用时会return new()，但是第二次不会，等于它在整个程序运行时只使用一个变量
                if (_Instance == null)
                {
                    _Instance = new MyClass();
                }
                return _Instance;
            }
            set { }
        }
        public string Name;

        public Form5 form5 = null;

    }
}
