using System.ComponentModel.DataAnnotations;

namespace PcComponents.Blazor.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}
