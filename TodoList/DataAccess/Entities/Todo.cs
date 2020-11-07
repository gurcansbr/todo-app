using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Enums;

namespace TodoList.Entities
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Max length can be 500 characters for this field")]
        public string Description { get; set; }

        [Required]
        public Period Period { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
