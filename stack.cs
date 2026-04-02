using System.Security.AccessControl;

 // stack = LIFO data structure. Last-In First-Out
  //               stores objects into a sort of "vertical tower"
  //               push() to add objects to the top
  //               pop() to remove objects from the top

Stack<string> stack = new Stack<string>();

stack.Push("CSGO");
stack.Push("Valorant");
stack.Push("LOL");
stack.Push("Fifa");
stack.Push("Roblox");

Console.WriteLine(string.Join(", ", stack));
System.Console.WriteLine(stack.Peek()); //this will not delete the object
System.Console.WriteLine(stack.Contains("LOL")); //see if it true/false
System.Console.WriteLine(stack.Contains("muck"));

string myFavGame = stack.Pop();

for (int i = 0; i < 5; i++) //depends on how many you add, you can run out of memory
{
    stack.Push("muck");
}

System.Console.WriteLine(string.Join(", ", stack));

System.Console.WriteLine(myFavGame);

 // uses of stacks?
  // 1. undo/redo features in text editors
  // 2. moving back/forward through browser history
  // 3. backtracking algorithms (maze, file directories)
  // 4. calling functions (call stack)