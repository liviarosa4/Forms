namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = maskedTextBox2 + "\n" + richTextBox1.Text;
            maskedTextBox2.Focus();
            maskedTextBox2.Text = "";
            progressBar1.Value += 10;
            label3.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                maskedTextBox2.Enabled = false;
                btnOk.Enabled = false;
                richTextBox1.Enabled = false;
                MessageBox.Show("Terminou");
            }


        }
    }
}