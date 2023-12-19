using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    public class LINQ_HT10
    {
        public void LINQ()
        {
            // 1
            Console.WriteLine(string.Join(", ", Enumerable.Range(10, 50)));

            // 2
            Console.WriteLine(string.Join(", ", Enumerable.Range(10, 50).Where(x => x % 3 == 0)));

            // 3
            Console.WriteLine(string.Concat(Enumerable.Repeat("Linq", 10)));

            // 4
            Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(word => word.Contains("a"))));

            // 5
            Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Select(word => word.Count(c => c == 'a'))));

            // 6
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Any(word => word == "abb"));

            // 7
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').OrderByDescending(word => word.Length).First());

            // 8
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Select(word => word.Length).Average());

            // 9
            Console.WriteLine(new string("aaa;xabbx;abb;ccc;dap;zh".Split(';').OrderBy(word => word.Length).First().Reverse().ToArray()));

            // 10
            Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').FirstOrDefault(word => word.StartsWith("aa"))?.Skip(2).All(c => c == 'b') ?? false);

            // 11
            Console.WriteLine(Enumerable.Range(0, 10).Skip(2).Reverse().Where(i => i % 2 == 0).Select(i => "aaa;xabbx;abb;ccc;dap".Split(';')[i]).FirstOrDefault(word => word.EndsWith("bb")));
        }
    }
}
