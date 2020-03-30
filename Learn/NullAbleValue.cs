using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    // 可空类型
    class NullAbleValue
    {
        public void PrintValue()
        {
            int? i = 3;
            // 等同于
            Nullable<int> j = new Nullable<int>(3);
            Console.WriteLine(i);
            Console.WriteLine(j);
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14159;

            bool? boolval = new bool?();
            Console.WriteLine($"{num1},{num2},{num3},{num4},{boolval}");

            // Null 合并运算符(??)
            num3 = num1 ?? 7.77;
            // 基本等同于三目运算符
            Console.WriteLine(num3);
        }
    }
}
