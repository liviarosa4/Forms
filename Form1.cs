namespace Apagando_Registros;
using MySql.Data.MySqlClient;

public partial class Form : System.Windows.Forms.Form
{
    private string connectionString = "Server=localhost;Database=Registro;Uid=root;Password='';";
    public Form()
    {
        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        string nome = txtNomeCliente.Text.Trim();
        string cpf = mskCpf.Text.Trim();
        string rg = mskRg.Text.Trim();
        string celular = mskTelefone.Text.Trim();
        string dataNascimento = mskDataNascimento.Text.Trim();
        string ufNascimento = comboBox1.SelectedItem?.ToString();
        string sexo = cmbSexo.SelectedItem?.ToString();


        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
            string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
        {
            MessageBox.Show("Digite em Todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
        {
            MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Cliente (nome_completo, cpf, rg, celular, data_nascimento, sexo, uf_nascimento) " +
                             "VALUES (@Nome, @CPF, @RG, @Celular, @DataNascimento, @Sexo, @UFnascimento)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@RG", rg);
                    cmd.Parameters.AddWithValue("@Celular", celular);
                    cmd.Parameters.AddWithValue("@DataNascimento", parsedDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cliente cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        string codigoCliente = txtCodigoCliente.Text.Trim();

        if (string.IsNullOrEmpty(codigoCliente))
        {
            MessageBox.Show("Por favor, informe o código do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Cliente WHERE Cliente = @Cliente";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cliente", codigoCliente);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cliente excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum cliente foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Cliente";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{result} Cliente excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
    


















