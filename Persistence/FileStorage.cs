using System.IO;
using System.Text.Json;
using TaskTracker.Models;

namespace TaskTracker.Persistence;

public class FileStorage
{
    private string _filePath;

    public FileStorage(string filePath)
    {
        _filePath = filePath;

        if(!File.Exists(_filePath))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);
            File.WriteAllText(_filePath, "[]");
        }
    }

    public List<TaskItem> Load()
    {
        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
    }

    public void Save(List<TaskItem> tasks)
    {
        var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(_filePath, json);
    }
        
    
}