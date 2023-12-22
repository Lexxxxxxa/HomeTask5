using ClassLibraryForHomeTask5;
using System.Collections;
using System.Collections.Generic;

namespace TestProject
{
    public class TestList
    {

        public static void TestListAdd(IList list)
        {
            list.Add(1);

            Console.WriteLine(list[0]);
        }

        public static void TestListInsert(IList list)
        {
            list.Add(1);
            list.Add(3);
            list.Insert(1, 2);

            Console.WriteLine(list[1]);
        }

        public static void TestListRemove(IList list)
        {
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Remove(3);

            Console.WriteLine($"{list[0]} {list[1]}");
        }

        public static void TestListRemoveAt(IList list)
        {
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.RemoveAt(1);

            Console.WriteLine($"{list[0]} {list[1]}");
        }

        public static void TestListClear(IList list)
        {
            list.Add(1);
            list.Add(3);
            list.Add(2);

            list.Clear();
            Console.WriteLine(list.Count);
        }

        public static void TestListContains(IList list)
        {
            list.Add(1);

            Console.WriteLine($"{list.Contains(2)}, {list.Contains(1)}");
        }

        public static void TestListIndexOf(IList list)
        {
            list.Add(1);
            list.Add(3);
            list.Add(2);

            Console.WriteLine(list.IndexOf(2));
        }
    }
}
