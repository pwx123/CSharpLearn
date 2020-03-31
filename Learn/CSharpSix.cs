using System;
using System.Collections.Generic;

namespace Learn
{
    class CSharpSix
    {
        // public string FirstName { get; } //删掉 private set，表达只读属性
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public CSharpSix(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public override string ToString() => FirstName + " " + LastName;
        public string AllCaps()
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();
            Console.WriteLine($"Hello {FirstName}, all Name {ToString()}");
            // nameof 返回任何变量、类型或类型成员的名称
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));
            return ToString();
        }
    }
}
