using TaskTracker.Repository;
using TaskTracker.Persistence;
using TaskTracker.Models;

namespace TaskTracker;

class Program
{
    static void Main(string[] args)
    {
        FileStorage filestorage = new("Data/task.json");        
        TaskRepository taskRepository = new(filestorage);

        TaskItem taskItem = new("Do Laundry");
        taskRepository.AddTask(taskItem);
    }

}
