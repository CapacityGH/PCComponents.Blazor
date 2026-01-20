using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace PcComponents.Blazor.Models
{
    public class PcComponent
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateOnly ReleaseDate { get; set; }

        [ValidateNever]
        public Category? Category { get; set; }

        // FK
        public int CategoryId { get; set; }

    }
}
