using Lab6DoubleLinkLists;

namespace TestProject;

public class LinkedListStartingWithOneAtBackTests
{
    public DoublyLinkedList<int> linkedList;
    [SetUp]
    public void Setup()
    {
        linkedList = new DoublyLinkedList<int>();
        linkedList.AddLast(10);
    }

    [Test]
    public void Test1()
    {
        linkedList.AddLast(11);
        linkedList.AddFirst(1);

        Assert.That(1, Is.EqualTo(linkedList.First));
        Assert.That(11, Is.EqualTo(linkedList.Last));

        linkedList.RemoveLast();
        linkedList.RemoveFirst();

        Assert.That(10, Is.EqualTo(linkedList.Last));
    }
}
