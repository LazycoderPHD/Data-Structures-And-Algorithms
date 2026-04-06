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

        LinkedList<string> LK =new LinkedList<string>();

        LK.AddFirst("A");
        LK.AddFirst("B");
        LK.AddFirst("C");
        LK.AddFirst("D");
        LK.AddFirst("F");

        LK.RemoveFirst();

        Console.WriteLine($"[{string.Join(", ", LK)}]");
    }
}