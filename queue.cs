namespace DataStructures;

public class QueueDemo
{
    public static void RunQueueDemo()
    {
        // Queue = FIFO data structure. First-In First-Out
		//		   A collection designed for holding elements prior to processing
		//		   Linear data structure
		
		//        Add = Enqueue()
		//        rm = Dequeue()

        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Karen");
        queue.Enqueue("Chad");
        queue.Enqueue("Steve");
        queue.Enqueue("Drake");

        System.Console.WriteLine(queue);


        
    }
}