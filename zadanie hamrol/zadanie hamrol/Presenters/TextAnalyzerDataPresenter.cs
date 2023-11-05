
using System.Diagnostics;
using System.Text;
using zadanie_hamrol.Core.Services;
using zadanie_hamrol.Shared.Entities;
using zadanie_hamrol.Shared.Interfaces;

namespace zadanie_hamrol.Presenters
{
    public class TextAnalyzerDataPresenter
    {
        // ustawienie pól jako prywatne, nie chcemy by były one widoczne z zewnątrz klasy TextAnalyzerDataPresenter
        // pola te są wewnętrzną sprawą tej klasy, wartości tych pól przekazujemy lub inicjalizujemy w konstruktorze
        private TextBox _tb_AllSymbols;
        private TextBox _tb_UniqueItems;
        private TextBox _tb_Entropy;
        private TextBox _tb_Time;
        private DataGridView _rtb_Statistics;

        private ITextStatisticsService _myTextService;


        public TextAnalyzerDataPresenter(TextBox tb_AllSymbols, TextBox tb_UniqueItems, TextBox tb_Entropy,
            TextBox tb_Time, DataGridView rtb_Statistics)
        {
            // rapisanie sobie referencji do kontrolek, by móc się do nich odwoływać w innych miejscach w kodzie
            _tb_AllSymbols = tb_AllSymbols;
            _tb_UniqueItems = tb_UniqueItems;
            _tb_Entropy = tb_Entropy;
            _tb_Time = tb_Time;
            _rtb_Statistics = rtb_Statistics;

            // aktywacja serwisów - tutaj dokonujemy wyboru, które implementacja serwisu będzie tą, z której
            // chcemy korzystać
            _myTextService = new TextStatisticsSevice();
        }


        public void PerformTextAnalysis(string text)
        {
            // rozpoczęcie pomiaru czasu
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // przeprowadzenie analizy
            TextStatisticsData textStatisticsData = _myTextService.CountStatistics(text);

            // zakończenie pomiaru czasu
            sw.Stop();

            // przygotowanie tekstu do drukowania
            TextPrintingData textPrintingData = _myTextService.FillPrintingData(textStatisticsData);

            // drukowanie wyników
            _tb_AllSymbols.Text = textPrintingData.AllSymbolCount;
            _tb_UniqueItems.Text = textPrintingData.UniqueSymbolCount;
            _tb_Entropy.Text = textPrintingData.Entropy;
            _tb_Time.Text = sw.Elapsed.ToString();
            _rtb_Statistics.Rows.Clear();
            for (int i = 0; i < textPrintingData?.SymbolStatistics?.Count; i++)
            {
                int index = _rtb_Statistics.Rows.Add();
                _rtb_Statistics.Rows[index].Cells[0].Value = textPrintingData.SymbolStatistics[i].BinaryNotation;
                _rtb_Statistics.Rows[index].Cells[1].Value = textPrintingData.SymbolStatistics[i].DecimalNotation;
                _rtb_Statistics.Rows[index].Cells[2].Value = textPrintingData.SymbolStatistics[i].Symbol;
                _rtb_Statistics.Rows[index].Cells[3].Value = textPrintingData.SymbolStatistics[i].Frequency;
                _rtb_Statistics.Rows[index].Cells[4].Value = textPrintingData.SymbolStatistics[i].Probability;
                _rtb_Statistics.Rows[index].Cells[5].Value = textPrintingData.SymbolStatistics[i].InformationQuantity;
            }
        }
    }
}
