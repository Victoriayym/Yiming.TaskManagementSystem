using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yiming.API.TaskManagementSystem.Models;
using Yiming.API.TaskManagementSystem.ServicesInterface;
using Yiming.Core.Task_Management_System.Entities;
using Yiming.Core.Task_Management_System.RepositoryInterface;

namespace Yiming.API.TaskManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskHistoryRepository _taskHistoryRepository;
        public UserService(IUserRepository userRepository, ITaskHistoryRepository taskHistoryRepository,
            ITaskRepository taskRepository)
        {
            _userRepository = userRepository;
            _taskHistoryRepository = taskHistoryRepository;
            _taskRepository = taskRepository;
        }
        
        public async Task<AllTasksModel> AllTasks(int userId)
        {
            var allTasksModel = new AllTasksModel();
            allTasksModel.Tasks = await _taskRepository.GetTasksByUserId(userId);
            allTasksModel.TasksHistory= await _taskHistoryRepository.GetTasksHistoryByUserId(userId);
            return allTasksModel;
        }

        public async Task<Core.Task_Management_System.Entities.Task> CreateTask(Core.Task_Management_System.Entities.Task task)
        {
            return await _taskRepository.AddAsync(task);
        }

        public async Task<TaskHistory> CompleteTask(Core.Task_Management_System.Entities.Task task)
        {
            var taskHistory = new TaskHistory
            {
                UserId = task.UserId,
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate,
                Completed = DateTime.Now,
                Remarks = task.Remarks
            };
            var createdTaskHistory=await _taskHistoryRepository.AddAsync(taskHistory);
            await _taskRepository.DeleteAsync(task);
            return createdTaskHistory;
        }

        public async Task<IEnumerable<User>> AllUsers()
        {
            return await _userRepository.ListAllAsync();
        }
    }
}
