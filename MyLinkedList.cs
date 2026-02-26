using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyLinkedListLib
{
    public class MyLinkedList<T> : ICollection<T>
    {
        public MyLinkedListNode<T> Head { get; private set; }
        public MyLinkedListNode<T> Tail { get; private set; }
        private int count;

        public int Count => count;
        public bool IsReadOnly => false;

        #region Add
        public void AddFirst(T item)
        {
            var node = new MyLinkedListNode<T>(item, Head);
            if (count == 0)
                Tail = node;
            Head = node;
            count++;
        }

        public void AddLast(T item)
        {
            var node = new MyLinkedListNode<T>(item, null);
            if (count == 0)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;
            count++;
        }

        public void Add(T item) => AddLast(item);
        #endregion

        #region Remove
        public void RemoveFirst()
        {
            if (count != 0)
            {
                Head = Head.Next;
                count--;
                if (count == 0)
                    Tail = null;
            }
        }

        public void RemoveLast()
        {
            if (count != 0)
            {
                if (count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    MyLinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                        current = current.Next;
                    current.Next = null;
                    Tail = current;
                }
                count--;
            }
        }

        public bool Remove(T item)
        {
            if (Contains(item))
            {
                RemoveFirst();
                return true;
            }
            return false;
        }
        #endregion

        #region Clear
        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }
        #endregion

        #region Contains
        public bool Contains(T item)
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }
        #endregion

        #region Enumerate
        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void CopyTo(T[] array, int arrayIndex)
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }
        #endregion

        #region Helpers
        public T First() => Head.Value;
        #endregion
    }
}