using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class Reflection
    {
        public void PrintValue()
        {
            System.Reflection.MemberInfo info = typeof(Myclass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : Attribute
    {
        private string topic;
        public readonly string Url;
        public string Topic // Topic 是一个命名（named）参数
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
        public HelpAttribute(string url)  // url 是一个定位（positional）参数
        {
            this.Url = url;
        }
    }
    [HelpAttribute("Information on the class Myclass")]
    class Myclass
    {

    }
}
