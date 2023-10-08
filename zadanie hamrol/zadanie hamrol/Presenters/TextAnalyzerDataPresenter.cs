using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_hamrol.Shared.Interfaces;
using zadanie_hamrol.Core.Services;
using System.Diagnostics;

namespace zadanie_hamrol.Presenters
{
    internal class TextAnalyzerDataPresenter
    {
        private TextBox _tb_Length;
        private TextBox _tb_Letters;
        private TextBox _tb_Digits;
        private TextBox _tb_Special;
        private TextBox _tb_Time;
        private ITextAnalyzerService _textAnalyzerService;
        public TextAnalyzerDataPresenter(TextBox textbox1, TextBox textbox2, TextBox textbox3, TextBox textbox4, TextBox textbox5) 
        {
            _tb_Length = textbox1;
            _tb_Letters = textbox2;
            _tb_Digits = textbox3;
            _tb_Special = textbox4;
            _tb_Time = textbox5;
            _textAnalyzerService = new TextAnalyzerService();
        }

        public void PerformTextAnalysis(string text)
        {
            // przeprowadzenie analizy
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = _textAnalyzerService.PerformAnalysis(text);
            sw.Stop();

            // drukowanie wyników
            _tb_Length.Text = result.textLength.ToString();
            _tb_Letters.Text = result.hasLetter ? "TAK" : "NIE";
            _tb_Digits.Text = result.hasNumber ? "TAK" : "NIE";
            _tb_Special.Text = result.hasSpecial ? "TAK" : "NIE";
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
