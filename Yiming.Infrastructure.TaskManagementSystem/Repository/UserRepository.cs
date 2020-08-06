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
    public class UserRepository : ERepository<User>, IUserRepository
    {
        public UserRepository(TaskManagementSystemDbContext dbContext) : base(dbContext)
        {

        }

       

        
    }
}
