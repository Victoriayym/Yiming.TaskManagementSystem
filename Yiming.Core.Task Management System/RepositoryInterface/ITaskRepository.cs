﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yiming.Core.Task_Management_System.Entities;


namespace Yiming.Core.Task_Management_System.RepositoryInterface
{
    public interface ITaskRepository : IAsyncRepository<Entities.Task>
    {
        Task<ICollection<Entities.Task>> GetTasksByUserId(int userId);
    
    }
}
