using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1Rafaela39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dgv.DataSource = Comprador.Listar();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            string alterar = $"update {tabela} set Nome = '{Comprador.Nome}', Jogo = '{Comprador.Jogo}', whare id = '{Comprador.id}';";
            conexao.ExecutarComando(alterar);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string Nome, Jogo, Endereco;

            Nome = txtNome.Text;
            Jogo = txtJogo.Text;
            Endereco = txtEndereco.Text;

            if (Nome == "" && Jogo == "")
                MessageBox.Show("Ocorreu um erro, verifique se todos os campos foram preencidos");
            else
                MessageBox.Show("Sucesso!");

            txtNome.Clear();
            txtJogo.Clear();
            txtEndereco.Clear();
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by Nome;";
            return conexao.ExecutarConsulta(sql);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            compra.Nome = txtNome.Text;
            compra.Jogo = txtJogo.Text;
            compra.Endereco = txtEndereco.Text;

            combll.Editar(compra);

            MessageBox.Show("Alterado com sucesso!", "Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            combll.Listar();

            txtNome.Clear();
            txtJogo.Clear();
            txtEndereco.Clear();
        }

        public void Editar(JogoOTO compra)
        {
            string alterar = $"update {tabela} set Nome = '{Comprador.Nome}', Jogo = '{Comprador.Jogo}', whare id = '{Comprador.id}';";
            conexao.ExecutarComando(alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string excluir = $"delete from {tabela} where id = '{Comprador.id}';";
            conexao.ExecutarComando(excluir);

            txtNome.Clear();
            txtJogo.Clear();
            txtEndereco.Clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string Endereco;
            Endereco = txtEndereco.Text;

            if (CheckBox1.Checked)
                txtEndereco.Text = Dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            else
                txtEndereco.Clear();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = Dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtJogo.Text = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
