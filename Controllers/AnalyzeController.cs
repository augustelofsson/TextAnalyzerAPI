using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TextAnalyzer.Dtos;
using TextAnalyzer.Services;

namespace TextAnalyzer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnalyzeController : ControllerBase
    {
        private readonly ITextService _textService;

        public AnalyzeController(ITextService textService)
        {
            _textService = textService;
        }

        // GET /Analyze/{text}
        [HttpGet("{text}")]
        public ActionResult<AnalyzedDto> GetAnalyzedText(string text)
        {
            if (text == null)
            {
                return NotFound();
            }

            return _textService.GetTop10AnalyzedWords(text);
        }
    }
}