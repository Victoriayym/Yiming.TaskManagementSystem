using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yiming.API.TaskManagementSystem.Models;
using Yiming.Core.Task_Management_System.Entities;

namespace Yiming.API.TaskManagementSystem.ServicesInterface
{
    public interface IUserService
    {
        Task<AllTasksModel> AllTasks(int userId);
        Task<Core.Task_Management_System.Entities.Task> CreateTask(Core.Task_Management_System.Entities.Task task);
        Task<TaskHistory> CompleteTask(Core.Task_Management_System.Entities.Task task);
        Task<IEnumerable<User>> AllUsers();
    }
}
