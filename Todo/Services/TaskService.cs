using Todo.Models;
using Todo.Controllers;

namespace Todo.Services;

public static class TasksList
{
    public static List<Models.Task> tasksList = new() { };
    
    public static void Add()
    {
       tasksList.Add(new Models.Task()); 
    }
}