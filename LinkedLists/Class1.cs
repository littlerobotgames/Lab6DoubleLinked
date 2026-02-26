namespace Lab6DoubleLinkLists
{
    public interface IDoubleEndedCollection<T>
    {

        T First { get; }
        T Last { get; }
        int Length { get; }

        void AddLast(T value);
        void AddFirst(T value);
        void RemoveFirst();
        void RemoveLast();
        void InsertAfter(DNode<T> node, T value);
        void RemoveByValue(T value);
        void ReverseList();
    }
    public class DNode<T>
    {
        public T Value { get; set; }
        public DNode<T>? Previous { get; set; }
        public DNode<T>? Next { get; set; }
    }
    public class DoublyLinkedList<T> : IDoubleEndedCollection<T>
    {
        private DNode<T>? _head = null;
        private DNode<T>? _tail = null;
        public int Length { get; set; } = 0;

        public T First => _head.Value;

        public T Last => _tail.Value;

        public void AddFirst(T value)
        {
            DNode<T> dNode = new DNode<T>();
            dNode.Value = value;

            if (Length == 0)
            {
                _head = dNode;
                _tail = dNode;
            }
            else
            {
                _head.Next = dNode;
                dNode.Previous = _head;
                _head = dNode;
            }

            Length++;
        }

        public void AddLast(T value)
        {
            DNode<T>? dNode = new DNode<T>();
            dNode.Value = value;

            if (Length == 0)
            {
                _head = dNode;
                _tail = dNode;
            }
            else
            {
                _tail.Next = dNode;
                dNode.Previous = _tail;
                _tail = dNode;
            }
            Length++;
        }

        public void InsertAfter(DNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveByValue(T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            if (Length == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Previous = null;
            }

        }

        public void RemoveLast()
        {
            if (Length == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail = _tail.Previous;
                _tail.Next = null;
            }

            Length--;
        }

        public void ReverseList()
        {
            throw new NotImplementedException();
        }
    }
}
