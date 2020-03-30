using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            // 索引器
            Console.WriteLine("索引器");
            Indexer indexer = new Indexer();
            indexer["math"] = 100;
            Console.WriteLine(indexer["math"]);
            try
            {
                indexer["english"] = null;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            // 常量
            Console.WriteLine("\n常量");
            Console.WriteLine(Math.PI);
            Console.WriteLine(ConstValue.ConstName);
            const string MyName = "123";
            Console.WriteLine(MyName);
            // 属性 Property
            Console.WriteLine("\n属性 Property");
            var p = new Property();
            p.Age = 12;
            p.Name = "pwx";
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            // 可空类型
            Console.WriteLine("\n可空类型");
            NullAbleValue nullAbleValue = new NullAbleValue();
            nullAbleValue.PrintValue();
            //枚举
            Console.WriteLine("\n枚举");
            var enumValue = new EnumValue();
            enumValue.PrintValue();
            //继承
            Console.WriteLine("\n继承");
            var classInherit = new ClassInherit();
            classInherit.PrintValue();
            //反射
            Console.WriteLine("\n反射");
            var reflection = new Reflection();
            reflection.PrintValue();
        }
    }
}
