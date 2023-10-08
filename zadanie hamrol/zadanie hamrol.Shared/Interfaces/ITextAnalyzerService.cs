using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_hamrol.Shared.Entities;

namespace zadanie_hamrol.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {
       public TextAnalyzeResult PerformAnalysis(string text);
    }
}
