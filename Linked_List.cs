namespace DataStructures;
public class Linked_ListDemo
{
    public static void RunLinked_ListDemo()
    {
        // LinkedList =  Nodes are in 2 parts (data + address)
        //                        Nodes are in non-consecutive memory locations
        //                        Elements are linked using pointers

        //    advantages?
        //    1. Dynamic Data Structure (allocates needed memory while running)
        //    2. Insertion and Deletion of Nodes is easy. O(1) 
        //    3. No/Low memory waste

        //    disadvantages?
        //    1. Greater memory usage (additional pointer)
        //    2. No random access of elements (no index [i])
        //    3. Accessing/searching elements is more time consuming. O(n)

        LinkedList<string> LK_Stack =new LinkedList<string>();

        //LinkedList as a Stack
        LK_Stack.AddFirst("A"); //AddFirst for stack
        LK_Stack.AddFirst("B");
        LK_Stack.AddFirst("C");
        LK_Stack.AddFirst("D");
        LK_Stack.AddFirst("E");
        LK_Stack.AddFirst("F");

        LK_Stack.RemoveFirst(); //remove F
        Console.WriteLine($"[{string.Join(", ", LK_Stack)}]");

        Console.WriteLine();

        LinkedList<string> LK_Queue = new LinkedList<string>();
        //LinkedList as a Queue
        LK_Queue.AddLast("A"); //AddLast for queue
        LK_Queue.AddLast("B");
        LK_Queue.AddLast("C");
        LK_Queue.AddLast("D");
        LK_Queue.AddLast("E");
        LK_Queue.AddLast("F");

        LK_Queue.RemoveFirst();
        Console.WriteLine($"[{string.Join(", ", LK_Queue)}]");
    }
}