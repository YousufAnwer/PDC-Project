using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Dtos.TaskDtos
{
   public class TaskDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
    }
}
