using Lab6DoubleLinkLists;

namespace TestProject;

public class LinkedListStartingWithThreeTestscs
{
    public DoublyLinkedList<int> linkedList;
    [SetUp]
    public void Setup()
    {
        linkedList = new DoublyLinkedList<int>();
        linkedList.AddFirst(3);
        linkedList.AddFirst(2);
        linkedList.AddFirst(1);
    }

    [Test]
    public void Test1()
    {
        linkedList.ReverseList();

        Assert.AreEqual(linkedList.Last, 1);
        Assert.AreEqual(linkedList.First, 3);
    }
}
