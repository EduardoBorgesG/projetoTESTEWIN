using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoTESTEWIN.Nascimento
{
    public partial class NascimentoTela : Form
    {
        Conec con = new Conec();
        string sql;
        MySqlCommand cmd;
        string id;
        public NascimentoTela()
        {
            InitializeComponent();
        }
        
        private void LimparCampos()
        {
            //METODO PARA EFETUAR A LIMPEZA DOS CAMPOS PÓS INCLUSÃO
            txtNomeR.Clear();
            mtxtDataN.Clear();
            txtNomeM.Clear();
            mtxtDataM.Clear();
            mtxtCPFM.Clear();
            txtNomePai.Clear();
            mtxtDataP.Clear();
            mtxtCPFP.Clear();
            mtxtDataRegistro.Clear();
        }
        private void IncluirRegistro()
        {
            //VERIFICAÇÃO PARA SABER SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if (txtNomeR.Text == "" || mtxtDataN.Text == "  /  /" || txtNomeM.Text == "" || mtxtDataM.Text == "  /  /" || mtxtCPFM.Text == "" || txtNomePai.Text == "" || mtxtDataP.Text == "  /  /" || mtxtCPFP.Text == "" || mtxtDataRegistro.Text == "  /  /")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos para a inserção do registro", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }
            //COMANDO PARA REALIZAR A INCLUSÃO DO REGISTRO NO BANCO DE DADOS
            con.AbrirCon();
            sql = "INSERT INTO nascimento(nomeR, dataNRda, nomeM, dataNM, cpfM, nomeP, dataNP, cpfP, dataR) VALUES (@txtNomeR, @mtxtDataN, @txtNomeM, @mtxtDataM, @mtxtCPFM, @txtNomeP, @mtxtDataP, @mtxtCPFP, @mtxtDataRegistro)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@txtNomeR", txtNomeR.Text);
            DateTime Ndata = Convert.ToDateTime(mtxtDataN.Text);
            cmd.Parameters.Add("@mtxtDataN", MySqlDbType.Date).Value = Ndata;
            cmd.Parameters.AddWithValue("@txtNomeM", txtNomeM.Text);
            cmd.Parameters.AddWithValue("@mtxtCPFM", mtxtCPFM.Text);
            DateTime Mdata = Convert.ToDateTime(mtxtDataM.Text);
            cmd.Parameters.Add("@mtxtDataM", MySqlDbType.Date).Value = Mdata;
            cmd.Parameters.AddWithValue("@txtNomeP", txtNomePai.Text);
            cmd.Parameters.AddWithValue("@mtxtCPFP", mtxtCPFP.Text);
            DateTime Pdata = Convert.ToDateTime(mtxtDataP.Text);
            cmd.Parameters.Add("@mtxtDataP", MySqlDbType.Date).Value = Pdata;
            DateTime Rdata = Convert.ToDateTime(mtxtDataRegistro.Text);
            cmd.Parameters.Add("@mtxtDataRegistro", MySqlDbType.Date).Value = Rdata;
            cmd.ExecuteNonQuery();
            con.FecharCon();
            MessageBox.Show("Usuário incluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            var resultado = MessageBox.Show("Deseja incluir um novo Registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                LimparCampos();
            }
            else
            {
                Close();
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirRegistro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza de que deseja sair sem salvar os dados?", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
