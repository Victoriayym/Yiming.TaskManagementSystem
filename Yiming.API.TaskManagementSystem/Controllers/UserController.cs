using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yiming.API.TaskManagementSystem.ServicesInterface;
using Yiming.Core.Task_Management_System.Entities;

namespace Yiming.API.TaskManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("AllUsers")]
        public async Task<IActionResult> AllUsers()
        {
            var users = await _userService.AllUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("AllTasks/{userId:int}")]
        public async Task<IActionResult> AllTasks(int userId)
        {
            var tasks = await _userService.AllTasks(userId);
            return Ok(tasks);
        }

        [HttpPost]
        [Route("CreateTask")]
        public async Task<IActionResult> CreateTask(Core.Task_Management_System.Entities.Task task)
        {
            var createdTask = await _userService.CreateTask(task);
            return Ok(createdTask);
        }

        [HttpPost]
        [Route("CompleteTask")]
        public async Task<IActionResult> CompleteTask(Core.Task_Management_System.Entities.Task task)
        {
            var taskHistory = await _userService.CompleteTask(task);
            return Ok(taskHistory);
        }
    }
}
