namespace DataStructures;
public class Linked_ListDemo
{
    public static void RunLinked_ListDemo()
    {
        LinkedList<string> LK =new LinkedList<string>();

        LK.AddFirst("A");
        LK.AddFirst("B");
        LK.AddFirst("C");
        LK.AddFirst("D");
        LK.AddFirst("F");

        Console.WriteLine($"[{string.Join(", ", LK)}]");
    }
}