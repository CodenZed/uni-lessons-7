using System.Windows.Forms;

namespace uni_lessons_7
{
    public partial class Form1 : Form
    {
        int num;
        int cehd = 0;
        Random r = new Random();
        ErrorProvider errorProvider1 = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ədəd daxil edin");
                return;
            }

            int axtarilan;

            if (!int.TryParse(textBox1.Text, out axtarilan))
            {
                errorProvider1.SetError(textBox1, "Yalnız ədəd daxil edin");
                return;
            }

            if (axtarilan < 0 || axtarilan > 100)
            {
                errorProvider1.SetError(textBox1, "0-100 arasında ədəd daxil edin");
                return;
            }

            cehd++;

            if (axtarilan == num)
            {
                richTextBox1.Text =
                    "Oyunu qazandınız!\n" +
                    "Cəhd sayı: " + cehd;

                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                richTextBox1.Text =
                    "Siz yanlış tapdınız!\n" +
                    "Cəhd sayı: " + cehd + "\n";

                if (axtarilan < num)
                {
                    richTextBox1.Text +=
                        "Daxil etdiyiniz ədəd gizli ədəddən kiçikdir.";
                }
                else
                {
                    richTextBox1.Text +=
                        "Daxil etdiyiniz ədəd gizli ədəddən böyükdür.";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = r.Next(0, 101);

            cehd = 0;

            textBox1.Clear();

            richTextBox1.Clear();

            textBox1.Enabled = true;
            button1.Enabled = true;

            errorProvider1.Clear();
        }
    }
}