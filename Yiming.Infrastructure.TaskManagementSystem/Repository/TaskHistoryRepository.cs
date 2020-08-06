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
    public class TaskHistoryRepository : ERepository<TaskHistory>, ITaskHistoryRepository
    {
        public TaskHistoryRepository(TaskManagementSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<ICollection<TaskHistory>> GetTasksHistoryByUserId(int userId)
        {
            return await _dbContext.TasksHistory.Include(th=>th.User).Where(th => th.UserId == userId).ToListAsync();
        }
    }
}
