using static TestProject.TestList;

namespace TestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestListAdd();
            TestListInsert();
            TestListRemove();
            TestListRemoveAt();
            TestListClear();
            TestListContains();
            TestListIndexOf();
            TestListToArray();
            TestListReverse();
        }
    }
}