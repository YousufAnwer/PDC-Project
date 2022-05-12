using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
    }
}
