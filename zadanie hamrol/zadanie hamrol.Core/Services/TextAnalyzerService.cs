using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_hamrol.Shared.Entities;
using zadanie_hamrol.Shared.Interfaces;

namespace zadanie_hamrol.Core.Services
{
    public class TextAnalyzerService : ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text) 
        { 
            TextAnalyzeResult result = new TextAnalyzeResult();
            int length = text.Length;
            result.textLength = length;

            bool ifLetters = false;
            for (int i = 0; i < length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    ifLetters = true;
                    break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    ifLetters = true;
                    break;
                }
            }
            if (ifLetters)
            {
                result.hasLetter = true;
            }
            else
            {
                result.hasLetter = false;
            }

            bool ifNumbers = false;
            for (int i = 0; i < length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    ifNumbers = true;
                    break;
                }
            }
            if (ifNumbers)
            {
                result.hasNumber = true;
            }
            else
            {
                result.hasNumber= false;
            }
            string specjal = "ąęóźżśćĄĘÓŹŻŚĆ";
            bool ifSpecjal = false;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < specjal.Length; j++)
                {
                    if (text[i] == specjal[j])
                    {
                        ifSpecjal = true;
                    }
                }
            }
            if (ifSpecjal)
            {
                result.hasSpecial = true;
                result.hasLetter = true;
            }
            else
            {
                result.hasSpecial= false;
            }
            return result;
        }
    }
}
