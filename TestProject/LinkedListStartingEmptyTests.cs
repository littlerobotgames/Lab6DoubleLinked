using Lab6DoubleLinkLists;

namespace Lab6DoubleLinkLists
{
    [TestFixture]
    public class Tests
    {
        DoublyLinkedList<int> doublyLinked;
        [SetUp]
        public void Setup()
        {
            doublyLinked = new DoublyLinkedList<int>();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(doublyLinked.Length, 0);
            doublyLinked.AddLast(10);
            doublyLinked.AddFirst(1);
            Assert.AreEqual(doublyLinked.Length, 2);

            Assert.AreEqual(doublyLinked.First, 1);
            Assert.AreEqual(doublyLinked.Last, 10);
        }
    }
}