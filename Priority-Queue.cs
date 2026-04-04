namespace DataStructures;
public class Priority_QueueDemo
{
    public static void RunPriority_QueueDemo()
    {
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
    }
}