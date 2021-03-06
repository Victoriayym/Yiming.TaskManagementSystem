﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yiming.Core.Task_Management_System.Entities;

namespace Yiming.Core.Task_Management_System.RepositoryInterface
{
    public interface ITaskHistoryRepository : IAsyncRepository<TaskHistory>
    {
        Task<ICollection<TaskHistory>> GetTasksHistoryByUserId(int userId);
    }
}
