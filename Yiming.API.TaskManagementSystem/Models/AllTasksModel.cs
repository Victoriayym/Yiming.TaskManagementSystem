using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yiming.Core.Task_Management_System.Entities;

namespace Yiming.API.TaskManagementSystem.Models
{
    public class AllTasksModel
    {
        public ICollection<Core.Task_Management_System.Entities.Task> Tasks { get; set; }
        public ICollection<TaskHistory> TasksHistory { get; set; }
    }
}
