using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Yiming.Core.Task_Management_System.Entities
{
    public class TaskHistory
    {
        public int TaskId { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Description{ get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? Completed { get; set; }

        public string Remarks { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
