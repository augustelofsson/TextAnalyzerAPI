using System;
using System.Linq;
using TextAnalyzer.Dtos;
using TextAnalyzer.Services;

namespace TextAnalyzer
{
    public class TextService : ITextService
    {
        public AnalyzedDto GetTop10AnalyzedWords(string words)
        {

            var wordsArray = words.ToLower().Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '´', '`', '*', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var distWordsArray = wordsArray.Distinct();
            AnalyzedDto analyzedWords = new();

            foreach (var word in distWordsArray)
            {
                var wordCount = wordsArray.Where(x => x == word).ToArray();
                analyzedWords.AnalyzedWords.Add(new WordDto
                {
                    Name = word,
                    Count = wordCount.Length
                });
            }
            var sorted = analyzedWords.AnalyzedWords.OrderByDescending(x => x.Count).Take(10).ToList();
            analyzedWords.AnalyzedWords = sorted;

            return analyzedWords;
        }
    }
}