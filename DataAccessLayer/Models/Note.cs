using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
