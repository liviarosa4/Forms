namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalv_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos de texto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!rdbsexo1.Checked && !rdbsexo2.Checked)
            {
                MessageBox.Show("Selecione o sexo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!ckbfut.Checked && !ckbSeries.Checked && !ckbsharp.Checked && !ckbVolei.Checked && !ckbXadrez.Checked)
            {
                MessageBox.Show("Selecione pelo menos um hobby.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!rdbmanha.Checked && !rdbtarde.Checked && !rdbnoite.Checked)
            {
                MessageBox.Show("Selecione um horário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Matrícula Feita!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {




            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


            comboBox1.SelectedIndex = -1;


            lstmesinicio.Items.Clear();


            textBox1.Focus();





            rdbsexo1.Checked = false;
            rdbsexo2.Checked = false;


            ckbfut.Checked = false;
            ckbSeries.Checked = false;
            ckbsharp.Checked = false;
            ckbVolei.Checked = false;
            ckbXadrez.Checked = false;


            rdbnoite.Checked = false;
            rdbtarde.Checked = false;
            rdbmanha.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void lstmesinicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedItem != null)
                {
                    string selectedItem = comboBox1.SelectedItem.ToString();
                    lstmesinicio.Items.Clear();

                    switch (selectedItem)
                    {
                        case "Técnico em Desenvolvimento de Sistemas":
                            lstmesinicio.Items.Add("Setembro");
                            lstmesinicio.Items.Add("Outubro");
                            rdbmanha.Visible = true;
                            rdbnoite.Visible = false;
                            rdbtarde.Visible = true;
                            break;

                        case "Técnico em Informática para Internet":
                            lstmesinicio.Items.Add("Setembro");
                            lstmesinicio.Items.Add("Novembro");
                            rdbmanha.Visible = false;
                            rdbnoite.Visible = true;
                            rdbtarde.Visible = true;
                            break;

                        case "Técnico em Design Gráfico":
                            lstmesinicio.Items.Add("Agosto");
                            lstmesinicio.Items.Add("Outubro");
                            lstmesinicio.Items.Add("Novembro");
                            rdbmanha.Visible = true;
                            rdbnoite.Visible = true;
                            rdbtarde.Visible = true;
                            break;

                        default:
                            MessageBox.Show("Curso não Encontrado: " + selectedItem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum curso selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}

        
    
