using MyLinkedListLib;

namespace StackLib
{
    public class Stack<T>
    {
        private MyLinkedList<T> items = new MyLinkedList<T>();

        public void Push(T item)
        {
            items.AddFirst(item);
        }

        public T Pop()
        {
            T item = items.First();
            items.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            return items.First();
        }
    }
}