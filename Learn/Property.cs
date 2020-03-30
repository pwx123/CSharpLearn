using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    // 属性
    class Property
    {
        public int Age
        {
            get; set;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value + "test";
            }
        }
    }
}
