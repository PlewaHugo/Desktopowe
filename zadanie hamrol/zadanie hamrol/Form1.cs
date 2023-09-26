namespace zadanie_hamrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Text = richTextBox1.Text;
            int length = Text.Length;
            textBox1.Text = length.ToString();

            bool ifLetters = false;
            for (int i = 0; i < length; i++)
            {
                if (Text[i] >= 'a' && Text[i] <= 'z')
                {
                    ifLetters = true; 
                    break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (Text[i] >= 'A' && Text[i] <= 'Z')
                {
                    ifLetters = true;
                    break;
                }
            }
            if (ifLetters)
            {
                textBox2.Text = "TAK";
            }
            else 
            {
                textBox2.Text = "NIE";
            }

            bool ifNumbers = false;
            for (int i = 0; i < length; i++)
            {
                if (Text[i] >= '0' && Text[i] <= '9')
                {
                    ifNumbers = true;
                    break;
                }
            }
            if (ifNumbers)
            {
                textBox3.Text = "TAK";
            }
            else
            {
                textBox3.Text = "NIE";
            }
            string specjal = "¹êóŸ¿œæ";
            bool ifSpecjal = false;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < specjal.Length; j++)
                {
                    if (Text[i] == specjal[j])
                    {
                        ifSpecjal = true;
                    }
                }
            }
            if (ifSpecjal)
            {
                textBox4.Text = "TAK";
                textBox2.Text = "TAK";
            }
            else
            {
                textBox4.Text = "NIE";
            }
        }
    }
}