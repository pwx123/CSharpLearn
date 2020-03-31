using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    public delegate int NumberChanger(int n);
    public delegate void GreetingDelegate(string name);
    class DelegateValue
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        // 例1
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning," + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好," + name);
        }
        // 此方法接受一个GreetingDelegate类型的方法作为参数
        private static void GreetPeople(string name, GreetingDelegate greetingDelegate)
        {
            greetingDelegate(name);
        }
        public void PrintValue()
        {
            // 创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            // 使用委托调用方法
            int a = nc1(25);
            Console.WriteLine(a); //35
            Console.WriteLine(GetNum());
            int b = nc2(5);
            Console.WriteLine(b); //175
            Console.WriteLine(GetNum());
            // 例1
            GreetPeople("Jimmy Zhang", EnglishGreeting);
            GreetPeople("张子扬", ChineseGreeting);
            GreetingDelegate delegate1;
            delegate1 = EnglishGreeting;
            delegate1 += ChineseGreeting;
            // 多播
            GreetPeople("王五", delegate1);
            delegate1("张三");
        }
    }
}
