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

        queue.Dequeue(); // will cause an exception if you dequeue more than you have on enqueue
        queue.Dequeue();
        queue.Dequeue();


        System.Console.WriteLine(string.Join(", ", queue));
        // System.Console.WriteLine(queue.Peek());
        System.Console.WriteLine(queue.Count);
        System.Console.WriteLine(queue.Contains("Karen"));
        System.Console.WriteLine(queue.Contains("Drake"));

        // Where are queues useful?
		
		// 1. Keyboard Buffer (letters should appear on the screen in the order they're pressed)
		// 2. Printer Queue (Print jobs should be completed in order)
		// 3. Used in LinkedLists, PriorityQueues, Breadth-first search
		
    }
}