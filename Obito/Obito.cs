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

namespace projetoTESTEWIN.Obito
{
    public partial class Obito : Form
    {
        Conec con = new Conec();
        string sql;
        MySqlCommand cmd;
        string id;
        public Obito()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtNomeF.Clear();
            mtxtDataF.Clear();
            txtNomeM.Clear();
            mtxtDataM.Clear();
            txtNomeP.Clear();
            mtxtDataP.Clear();
            mtxtDataO.Clear();
            mtxtDataR.Clear();
        }
        private void IncluirUsuario()
        {
            //METODO PARA VERIFICAR SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if (txtNomeF.Text == "" || mtxtDataF.Text == "  /  /" || txtNomeM.Text == "" || mtxtDataM.Text == "  /  /" || txtNomeP.Text == "" || mtxtDataP.Text == "  /  /" || mtxtDataO.Text == "  /  /" || mtxtDataR.Text == "  /  /")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos para a inserção do registro", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //METODO PARA INCLUSÃO DE USUARIO
            con.AbrirCon();
            sql = "INSERT INTO obito(nomeF, dataNF, nomeM, dataM, nomeP, dataP, dataO, dataR) VALUES (@txtNomeF, @mtxtDataF, @txtNomeM, @mtxtDataM, @txtNomeP, @mtxtDataP,@mtxtDataO, @mtxtDataR)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@txtNomeF", txtNomeF.Text);
            DateTime Fdata = Convert.ToDateTime(@mtxtDataF.Text);
            cmd.Parameters.Add("@mtxtDataF", MySqlDbType.Date).Value = Fdata;
            cmd.Parameters.AddWithValue("@txtNomeM", txtNomeM.Text);
            DateTime Mdata = Convert.ToDateTime(@mtxtDataM.Text);
            cmd.Parameters.Add("@mtxtDataM", MySqlDbType.Date).Value = Mdata;
            cmd.Parameters.AddWithValue("@txtNomeP", txtNomeP.Text);
            DateTime Pdata = Convert.ToDateTime(@mtxtDataP.Text);
            cmd.Parameters.Add("@mtxtDataP", MySqlDbType.Date).Value = Pdata;
            DateTime Odata = Convert.ToDateTime(@mtxtDataO.Text);
            cmd.Parameters.Add("@mtxtDataO", MySqlDbType.Date).Value = Odata;
            DateTime Rdata = Convert.ToDateTime(@mtxtDataR.Text);
            cmd.Parameters.Add("@mtxtDataR", MySqlDbType.Date).Value = Rdata;
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
            IncluirUsuario();
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
