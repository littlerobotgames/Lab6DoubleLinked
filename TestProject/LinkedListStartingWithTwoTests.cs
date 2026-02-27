using Lab6DoubleLinkLists;

namespace TestProject;

public class LinkedListStartingWithTwoTests
{
    public DoublyLinkedList<int> linkedList;
    [SetUp]
    public void Setup()
    {
        linkedList = new DoublyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddFirst(2);
    }

    [Test]
    public void Test1()
    {
        linkedList.RemoveFirst();
        linkedList.RemoveLast();

        Assert.AreEqual(linkedList.Length, 0);
    }
}
