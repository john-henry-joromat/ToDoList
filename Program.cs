List<string> toDoList = new List<string>();
bool ToDo = true;

while (ToDo)
{
    Console.Clear();
    Console.WriteLine("To-do List");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Task(s)");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Choose an option: ");
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            AddTask(toDoList);
            break;
        case "2":
            ViewTasks(toDoList);
            break;
        case "3":
            ToDo = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}


static void AddTask(List<string> toDoList)
{
    Console.WriteLine("Enter a new Task: ");
    string task = Console.ReadLine();
    toDoList.Add(task);
    Console.WriteLine("Task Added!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void ViewTasks(List<string> toDoList)
{
    Console.WriteLine("Your To-Do List: ");
    if(toDoList.Count == 0)
    {
        Console.WriteLine("No task in the list.");
    }
    else
    {
        for(int i = 0; i < toDoList.Count; i++) { 
            Console.WriteLine($"{i + 1}. {toDoList[i]}"); 
        }
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}