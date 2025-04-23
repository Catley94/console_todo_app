namespace console_todo_app;

class Program
{
    
    
    
    static void Main(string[] args)
    {
        bool keepRunning = true;
        List<Task> tasks = new List<Task>();
        
        foreach (var arg in args)
        {
            Console.WriteLine("Argument passed in: " + arg);
        }

        while (keepRunning)
        {
            
            Console.WriteLine("Welcome to Terminal Quick-ToDo");
            Console.WriteLine("1: Add a Task");
            Console.WriteLine("2: List all Tasks");
            Console.WriteLine("3: Delete a Task");
            Console.WriteLine("4: Exit");
            
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Add a Task
                    Console.WriteLine("What is the new Task?");
                    string? userTask = Console.ReadLine();
                    Task newTask = new Task(tasks.Count(), userTask);
                    tasks.Add(newTask);
                    break;
                case "2":
                    // List all Tasks
                    Console.WriteLine("____________________________________________________________________");
                    foreach (Task task in tasks)
                    {
                        Console.WriteLine("Task: " + task.ToDo);
                    }
                    Console.WriteLine("____________________________________________________________________");
                    break;
                case "3":
                    // Delete a Task
                    break;
                case "4":
                    // Exit
                    keepRunning = false;
                    break;
                default:
                    break;
            }
        }
        
    }
}