using TaskTracker.Models;

namespace TaskTracker.Interfaces;

interface ITaskRepository
{
    void AddTask(TaskItem taskItem);
    void UpdateTask(TaskItem taskItem);
    void DeleteTask(Guid Id);
    List<TaskItem> GetAllTask();
}