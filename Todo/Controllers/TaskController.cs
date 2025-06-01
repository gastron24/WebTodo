using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;
namespace Todo.Controllers;

[ApiController]
[Route("controller")]
public class AddTaskController : ControllerBase
{
    [HttpPost]
    [Route("AddTask")]
    public IActionResult InputTask([FromBody] Models.Task model)
    {

        if (model == null || string.IsNullOrEmpty(model.Name))
            throw new Exception("BadReques");

        Models.Task task = new Models.Task(
            model.Name,
            model.Description,
            status: 0,
            isComplete: false
            );
        Services.TasksList.tasksList.Add(task);

        return CreatedAtActionResult(nameof(InputTask), new task)  // доделать завтра


        
    }



}
