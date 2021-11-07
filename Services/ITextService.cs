using TextAnalyzer.Dtos;


namespace TextAnalyzer.Services
{
    public interface ITextService
    {
        AnalyzedDto GetTop10AnalyzedWords(string words);
    }
}