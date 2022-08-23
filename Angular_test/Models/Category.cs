using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angular_test.Models
{
    public class Category :BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Todo> Todos { get; set; }
    }
}
    