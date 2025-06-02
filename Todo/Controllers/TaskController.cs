    
using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;
namespace Todo.Controllers;

[ApiController]
[Route("[controller]")]
public class AddTaskController : ControllerBase
{
    [HttpPost("CreateTask")]
    public IActionResult InputTask([FromBody] Models.Task model)
    {

        if (model == null || string.IsNullOrEmpty(model.Name))
            return BadRequest("Task name is required");

        Models.Task task = new Models.Task(
            model.Name,
            model.Description,
            status: 0,
            isComplete: false
            );
        TasksList.AddTask(task);

        return CreatedAtAction(
           nameof(InputTask),
           new { id = task.Id },
           task
       );
    }
    [HttpGet("ShowTask")]
    
    public IActionResult ShowTasks([FromBody] Models.Task task)
    {
        return Ok(Services.TasksList.TasksLists);


    }

}
