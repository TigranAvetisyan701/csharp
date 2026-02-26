using MyLinkedListLib;
using StackLib;

Console.WriteLine("MyLinkedList");

MyLinkedList<int> list = new MyLinkedList<int>();
list.AddLast(1);
list.AddLast(2);
list.AddLast(3);
list.AddFirst(0);

Console.Write("List: ");
foreach (var item in list)
    Console.Write(item + " ");
Console.WriteLine();

Console.WriteLine("Contains 2: " + list.Contains(2));

list.RemoveFirst();
list.RemoveLast();
Console.Write("After RemoveFirst and RemoveLast: ");
foreach (var item in list)
    Console.Write(item + " ");
Console.WriteLine();

list.Clear();
Console.WriteLine("Count after Clear: " + list.Count);

Console.WriteLine("\nStack");

StackLib.Stack<string> stack = new StackLib.Stack<string>();
stack.Push("first");
stack.Push("second");
stack.Push("third");

Console.WriteLine("Peek: " + stack.Peek());
Console.WriteLine("Pop: " + stack.Pop());
Console.WriteLine("Pop: " + stack.Pop());
Console.WriteLine("Peek after two pops: " + stack.Peek());