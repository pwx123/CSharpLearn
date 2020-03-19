using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            // 索引器
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
            Console.WriteLine(Math.PI);
            Console.WriteLine(ConstValue.ConstName);
            const string MyName = "123";
            Console.WriteLine(MyName);
        }
    }
}
