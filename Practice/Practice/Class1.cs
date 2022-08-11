using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Class1
    {
        public void YuanZu()
        {
            var x = new[] {4.7,9};

            (int, int) y = (1, 2);
            (int a, int b) z = (3, 4);
            Console.WriteLine($"x中：{z.a}");
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(Class1.Function(6));
        }
        private static int Function(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return Function(num - 1) + Function(num - 2);
            }
        }
    }
}
