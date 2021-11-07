using System.ComponentModel.DataAnnotations;

namespace TextAnalyzer.Dtos
{
    public record WordDto {
        [Required]
        public string Name { get; init; }
        public int Count { get; set; }
    }
}