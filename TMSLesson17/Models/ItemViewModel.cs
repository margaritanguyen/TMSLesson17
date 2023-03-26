using System.ComponentModel.DataAnnotations;

namespace TMSLesson17.Models
{
    public class ItemViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
        
        public int EstimatedCount { get; set; }

        public int ActualCount { get; set; }

        public ItemViewModel(int id, string code, string name, int categoryId, int estimatedCount, int actualCount)
        {
            Id = id;
            Code = code;
            Name = name;
            CategoryId = categoryId;
            EstimatedCount = estimatedCount;
            ActualCount = actualCount;
        }
    }
}