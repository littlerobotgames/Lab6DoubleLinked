using Lab6DoubleLinkLists;

namespace TestProject;

public class LinkedListStartingWithOneAtFrontTests
{
    public DoublyLinkedList<int> linkedList;
    [SetUp]
    public void Setup()
    {
        linkedList = new DoublyLinkedList<int>();
        linkedList.AddFirst(1);
    }

    [Test]
    public void Test1()
    {
        linkedList.AddLast(11);
        linkedList.AddFirst(2);

        Assert.AreEqual(linkedList.First, 2);
        Assert.AreEqual(linkedList.Last, 11);

        linkedList.RemoveLast();
        linkedList.RemoveFirst();

        Assert.AreEqual(linkedList.Last, 10);
    }
}
