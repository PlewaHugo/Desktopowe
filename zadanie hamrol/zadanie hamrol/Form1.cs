using System.Security.Cryptography.X509Certificates;
using zadanie_hamrol.Presenters;

namespace zadanie_hamrol
{
    public partial class Form1 : Form
    {
        private TextAnalyzerDataPresenter textAnalyzerDataPresenter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textAnalyzerDataPresenter.PerformTextAnalysis(richTextBox1.Text);
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Pliki tekstowe (.txt)|.txt|Wszystkie pliki (.)|.";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox4, textBox5);
        }
    }
}