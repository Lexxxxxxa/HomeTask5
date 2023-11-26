using ClassLibraryForHomeTask5;

namespace TestProject
{
    public class TestList
    {

        public static void TestListAdd()
        {
            List list = new List();
            list.Add(1);

            Console.WriteLine(list[0]);
        }

        public static void TestListInsert()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Insert(1, 2);

            Console.WriteLine(list[1]);
        }

        public static void TestListRemove()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Remove(3);

            Console.WriteLine($"{list[0]} {list[1]}");
        }

        public static void TestListRemoveAt()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.RemoveAt(1);

            Console.WriteLine($"{list[0]} {list[1]}");
        }

        public static void TestListClear()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Add(2);

            list.Clear();
            Console.WriteLine(list.count);
        }

        public static void TestListContains()
        {
            List list = new List();
            list.Add(1);

            Console.WriteLine($"{list.Contains(2)}, {list.Contains(1)}");
        }

        public static void TestListIndexOf()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Add(2);

            Console.WriteLine(list.IndexOf(2));
        }

        public static void TestListToArray()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);
            list.Add(2);

            Console.WriteLine(list.ToArray());
        }

        public static void TestListReverse()
        {
            List list = new List();
            list.Add(1);
            list.Add(3);

            list.Reverse();
            Console.WriteLine($"{list[0]} {list[1]}");
        }
    }
}
