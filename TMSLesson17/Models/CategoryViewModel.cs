using System.ComponentModel.DataAnnotations;

namespace TMSLesson17.Models
{
    public class CategoryViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string Name { get; set; }

        public CategoryViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}