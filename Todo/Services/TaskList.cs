using Todo.Models;
using Todo.Controllers;

namespace Todo.Services;

public static class TasksList
{
    private static List<Models.Task> tasksList = new() { };
    
    public static List<Models.Task> TasksLists
    {
        get { return tasksList; }
    }


    public static void AddTask(Models.Task task)
    {
        tasksList.Add(task);
    }
   
    public static List<Models.Task> ShowAllTasks(Models.Task task)
    {
        return tasksList;
    }
}