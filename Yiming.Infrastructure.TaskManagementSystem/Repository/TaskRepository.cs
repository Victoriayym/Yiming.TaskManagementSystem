using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yiming.Core.Task_Management_System.Entities;
using Yiming.Core.Task_Management_System.RepositoryInterface;
using Yiming.Infrastructure.TaskManagementSystem.Data;

namespace Yiming.Infrastructure.TaskManagementSystem.Repository
{
    public class TaskRepository : ERepository<Core.Task_Management_System.Entities.Task>, ITaskRepository
    {
        public TaskRepository(TaskManagementSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<ICollection<Core.Task_Management_System.Entities.Task>> GetTasksByUserId(int userId)
        {
            return await _dbContext.Tasks.Include(t=>t.User).Where(t => t.UserId == userId).ToListAsync();
        }
    }
}
