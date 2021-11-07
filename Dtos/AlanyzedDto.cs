using System.Collections.Generic;

namespace TextAnalyzer.Dtos
{
    public class AnalyzedDto {
        public List<WordDto> AnalyzedWords { get; set; } = new();
    }
}