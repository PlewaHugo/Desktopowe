
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_hamrol.Core.Services;
using zadanie_hamrol.Shared.Entities;

namespace projekt01.Core.Services
{
    public class TextStatisticsService : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {
            TextStatisticsData data = new TextStatisticsData();

            data.AllSymbolCount = text.Length;
            data.UniqueSymbolCount = text.Distinct().Count();

            //Entropy
            double infoCharacter = 0;
            Dictionary<char, int> table = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (table.ContainsKey(c)) { table[c]++; }
                else { table.Add(c, 1); }
            }

            double freq;
            List<SymbolStatisticsData> symbolStatistics = new List<SymbolStatisticsData>();

            foreach (KeyValuePair<char, int> letter in table)
            {
                freq = letter.Value / text.Length;
                SymbolStatisticsData symbol = new SymbolStatisticsData();
                symbol.Symbol = letter.Key;
                symbol.Frequency = letter.Value;
                symbol.Probability = letter.Value / (double)text.Length;
                symbol.InformationQuantity = Math.Log((double)1 / symbol.Probability, 2);
                symbolStatistics.Add(symbol);
                infoCharacter += symbol.Probability * symbol.InformationQuantity;
            }
            //infoCharacter *= -1;

            data.Entropy = infoCharacter;
            data.SymbolStatistics = symbolStatistics;

            return data;

        }
    }
}
