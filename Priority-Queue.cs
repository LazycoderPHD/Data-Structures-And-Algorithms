namespace DataStructures;
public class Priority_QueueDemo
{
    public static void RunPriority_QueueDemo()
    {
        //Priority Queue = A FIFO data structure that serves elements
        //                             with the highest priorities first 
        //				  before elements with lower priority

        //Strings in default order
        PriorityQueue<double, int> Priority_Queue = new PriorityQueue<double, int>();
        {
            Priority_Queue.Enqueue(4.0, 1);
            Priority_Queue.Enqueue(3.0, 2);
            Priority_Queue.Enqueue(2.0, 4);
            Priority_Queue.Enqueue(1.0, 6);
            Priority_Queue.Enqueue(2.5, 3);
            Priority_Queue.Enqueue(1.5, 5);

            while (Priority_Queue.Count > 0)
            {
                Console.WriteLine(Priority_Queue.Dequeue());
            }
        }

        Console.WriteLine();

        //Strings in reverse order
        PriorityQueue<double, int> PQ = new PriorityQueue<double, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        {
            PQ.Enqueue(4.0, 1);
            PQ.Enqueue(3.0, 2);
            PQ.Enqueue(2.0, 4);
            PQ.Enqueue(1.0, 6);
            PQ.Enqueue(2.5, 3);
            PQ.Enqueue(1.5, 5);

            while (PQ.Count > 0)
            {
                Console.WriteLine(PQ.Dequeue());
            }
        }
    }
}