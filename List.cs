namespace DataStructures;
//public class ListDemo
//{
//    public static void RunListDemo()
//    {
//        int size;
//        int capacity = 4;
//        object[] a;
//    }
//}

public class Dynamic_ArrayDemo
{
    public static void RunDynamic_ArrayDemo()
    {
        // Khởi tạo đối tượng từ class vừa viết ở file Dynamic-Array.cs
        Dynamic_Array DA = new Dynamic_Array();
        //Dynamic_Array DA = new Dynamic_Array(5);

        // In ra capacity giống trong video
        Console.WriteLine($"Capacity: {DA.capacity}");
        DA.add("A");
        DA.add("B");
        DA.add("C");

        Console.WriteLine(DA);
    }
}