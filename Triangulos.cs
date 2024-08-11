namespace WinFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblclassificacao_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);


            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {

                string classificacao;
                if (lado1 == lado2 && lado2 == lado3)
                {
                    classificacao = "Equilátero";
                    PictureBox.Image = Image.FromFile("C:\\Users\\livia.srosa1\\source\\repos\\WinFormsApp23\\WinFormsApp23\\Resources\\caminho_para_imagem_equilatero_acutangulo.jpg.jfif");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    classificacao = "Isósceles";
                    PictureBox.Image = Image.FromFile("C:\\Users\\livia.srosa1\\source\\repos\\WinFormsApp23\\WinFormsApp23\\Resources\\Isósceles.jfif");
                }
                else
                {
                    classificacao = "Escaleno";
                    PictureBox.Image = Image.FromFile("C:\\Users\\livia.srosa1\\source\\repos\\WinFormsApp23\\WinFormsApp23\\Resources\\escaleno.jfif");
                }

                lblTexto.Text = "Classificação: " + classificacao;
            }
            else
            {
                lblTexto.Text = "Os lados fornecidos não formam um triângulo.";
                PictureBox.Image = null;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Text = string.Empty;
                    }
                    else if (ctrl is ComboBox)
                    {
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    }
                    else if (ctrl is RadioButton)
                    {
                        ((RadioButton)ctrl).Checked = false;
                    }
                    else if (ctrl is CheckBox)
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                }
            }
        }

        private void lbltexto_Click(object sender, EventArgs e)
        {

        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {

        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {

        }

        private void lblTexto_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
