using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Yiming.Core.Task_Management_System.Entities;

namespace Yiming.Infrastructure.TaskManagementSystem.Data
{
    public class TaskManagementSystemDbContext:DbContext
    {
        public TaskManagementSystemDbContext(DbContextOptions<TaskManagementSystemDbContext> options) : base(options)
        {

        }
        public DbSet<User> Userss { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskHistory> TasksHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(ConfigureUsers);
            modelBuilder.Entity<Task>(ConfigureTasks);
            modelBuilder.Entity<TaskHistory>(ConfigureTasksHistory);
        }

        private void ConfigureUsers(EntityTypeBuilder<User> modelbuilder)
        {
            modelbuilder.ToTable("Users");
            modelbuilder.HasKey(u => u.Id);
            modelbuilder.Property(u => u.Id).ValueGeneratedOnAdd();
            modelbuilder.Property(u => u.Email).HasColumnType("varchar(50)");
            modelbuilder.Property(u => u.Password).IsRequired().HasColumnType("varchar(10)");
            modelbuilder.Property(u => u.FullName).HasColumnType("varchar(50)");
            modelbuilder.Property(u => u.Mobileno).HasColumnType("varchar(50)");
        }

        private void ConfigureTasks(EntityTypeBuilder<Task> modelbuilder)
        {
            modelbuilder.ToTable("Tasks");
            modelbuilder.HasKey(t => t.Id);
            modelbuilder.Property(t => t.Id).ValueGeneratedOnAdd();
            modelbuilder.Property(t => t.UserId);
            modelbuilder.Property(t => t.Title).HasColumnType("varchar(50)");
            modelbuilder.Property(t => t.Description).HasColumnType("varchar(500)");
            modelbuilder.Property(t => t.DueDate).HasColumnType("datetime");
            modelbuilder.Property(t => t.Priority).HasColumnType("char(1)");
            modelbuilder.Property(t => t.Remarks).HasColumnType("varchar(500)");
        }

        private void ConfigureTasksHistory(EntityTypeBuilder<TaskHistory> modelbuilder)
        {
            modelbuilder.ToTable("TasksHistory");
            modelbuilder.HasKey(th => th.TaskId);
            modelbuilder.Property(th => th.TaskId).ValueGeneratedOnAdd();
            modelbuilder.Property(th => th.UserId);
            modelbuilder.Property(th => th.Title).HasColumnType("varchar(50)");
            modelbuilder.Property(th => th.Description).HasColumnType("varchar(500)");
            modelbuilder.Property(th => th.DueDate).HasColumnType("datetime");
            modelbuilder.Property(th => th.Completed).HasColumnType("datetime");
            modelbuilder.Property(th => th.Remarks).HasColumnType("varchar(500)");
        }
    }
}
