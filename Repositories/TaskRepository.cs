using TaskTracker.Interfaces;
using TaskTracker.Models;
using TaskTracker.Persistence;

namespace TaskTracker.Repository;

public class TaskRepository : ITaskRepository
{
    private readonly FileStorage _fileStorage;

    public TaskRepository(FileStorage filestorage)
    {
        _fileStorage = filestorage;
    }

    public void AddTask(TaskItem taskItem)
    {
        var taskItems = _fileStorage.Load();
        taskItems.Add(taskItem);
        _fileStorage.Save(taskItems);
    }

    public void UpdateTask(TaskItem taskItem)
    {

    }

    public void DeleteTask(Guid Id)
    {

    }

    public List<TaskItem> GetAllTask()
    {
        return _fileStorage.Load();
    }
}