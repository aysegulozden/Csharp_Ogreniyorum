namespace Lable_Textbox_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Ayþegül";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Ayþegül";
            label7.Text = "Özden";
            label8.Text = "23";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazýlým Mühendisliði";

            label9.Text = textBox1.Text;
        }
    }
}
