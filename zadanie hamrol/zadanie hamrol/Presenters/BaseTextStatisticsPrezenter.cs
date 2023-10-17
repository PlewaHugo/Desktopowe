using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_hamrol.Core.Services;
using zadanie_hamrol.Shared.Interfaces;

namespace zadanie_hamrol.Presenters
{
    internal class BaseTextStatisticsPrezenter
    {
        private RichTextBox _richTextBox;
        private ITextStatisticsService _ITextStatisticService;
        public BaseTextStatisticsPrezenter(RichTextBox richTextBox) 
        {
            _richTextBox = richTextBox;
        }
    }
}
