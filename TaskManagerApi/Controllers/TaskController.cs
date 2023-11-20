using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Controllers
{
    [Route("api/grimes/")]
    public class TaskController : ControllerBase
    {
        private ITask _task { get; set; }

        public TaskController(ITask task)
        {
            _task = task;
        }

        [HttpPost]
        [Route("AddTask")]
        public IActionResult Add(EntityTask task)
        {
            if (ModelState.IsValid) 
            {
                _task.Add(task);
                return Ok();
            } else 
            {
                return BadRequest(); 
            }
        }


        [HttpGet]
        [Route("ListTask")]
        public IActionResult List()
        {

            if (ModelState.IsValid)
            {
                var tasks = _task.Get();
                return Ok(tasks);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        [Route("EditTask")]
        public IActionResult Edit(EntityTask task)
        {
            if (ModelState.IsValid)
            {
                _task.Update(task);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteTask")]
        public IActionResult Delete(Guid Id)
        {
            var taskToRemove = _task.GetById(Id).Id;
            _task.Delete(taskToRemove);
            return Ok();
        }
    }
}
