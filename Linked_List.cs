using System.Collections.Generic;

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

        
        var nodeD = LK_Queue.Find("D"); // Tìm node chứa "D"

        //Chèn "?" sau node đó
        if (nodeD != null)
        {
            LK_Queue.AddAfter(nodeD, "?");
        }

        //tìm index của "F" A0 B1 C2 D3 E4 ?5 F6 <-- => index là 6
        LK_Queue.ToList().FindIndex(x => x == "F");
        Console.WriteLine(LK_Queue.ToList().FindIndex(x => x == "F"));

        //LK_Queue.RemoveFirst(); //remove A"

        if (LK_Queue.First != null && LK_Queue.Last != null) //kiểm tra xem danh sách mình có trống không?
        {
            Console.WriteLine(LK_Queue.First.Value); //xem đầu
            Console.WriteLine(LK_Queue.Last.Value); //xem đuôi
        }

        LK_Queue.AddFirst("0"); //Add 0 trước A
        LK_Queue.AddLast("G"); //Add G sau F
        Console.WriteLine($"[{string.Join(", ", LK_Queue)}]");

        //Kiểm tra xem danh sách mình có trống không?
        if (LK_Queue.First != null)
        {
            //Gán biến và xóa phần tử đầu
            string First = LK_Queue.First.Value; //Lấy giá trị
            LK_Queue.RemoveFirst(); //Xóa khỏi danh sách
        }

        //Kiểm tra xem danh sách mình có trống không?
        if (LK_Queue.Last != null)
        {
            //Gán biến và xóa phần tử cuối
            string Last = LK_Queue.Last.Value; //Lấy giá trị
            LK_Queue.RemoveLast(); //Xoá khỏi danh sách
        }
    }
}