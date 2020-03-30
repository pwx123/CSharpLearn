using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    // 枚举
    class EnumValue
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public void PrintValue()
        {
            Day day = Day.Mon;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
        }
    }
}
