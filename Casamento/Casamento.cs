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

namespace projetoTESTEWIN.Casamento
{
    public partial class Casamento : Form
    {
        Conec con = new Conec();
        string sql;
        MySqlCommand cmd;
        string id;
        public Casamento()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtNomeC1.Clear();
            mtxtDataC1.Clear();
            mtxtCPFC1.Clear();
            txtNomeMC1.Clear();
            mtxtDataMC1.Clear();
            mtxtCPFMC1.Clear();
            txtNomePC1.Clear();
            mtxtDataPC1.Clear();
            mtxtCPFPC1.Clear();
            txtNomeC2.Clear();
            mtxtDataC2.Clear();
            mtxtCPFC2.Clear();
            txtNomeMC2.Clear();
            mtxtDataMC2.Clear();
            mtxtCPFMC2.Clear();
            txtNomePC2.Clear();
            mtxtDataPC2.Clear();
            mtxtCPFPC2.Clear();
            mtxtDataRegistro.Clear();
            mtxtDataCasamento.Clear();
        }
        private void IncluirUsuario()
        {
            //PROCESSO PARA VALIDAÇÃO DE PREENCHIMENTO DOS CAMPOS
            if (txtNomeC1.Text == "" || mtxtDataC1.Text == "  /  /" || mtxtCPFC1.Text == "" || txtNomeMC1.Text == "" || mtxtDataMC1.Text == "  /  /" || mtxtCPFMC1.Text == "" || txtNomePC1.Text == "" || mtxtDataPC1.Text == "  /  /" || mtxtCPFPC1.Text == "" || txtNomeC2.Text == "" || mtxtDataC2.Text == "  /  /" || mtxtCPFC2.Text == "" || txtNomeMC2.Text == "" || mtxtDataMC2.Text == "  /  /" || mtxtCPFMC2.Text == "" || txtNomePC2.Text == "" || mtxtDataPC2.Text == "  /  /" || mtxtCPFPC2.Text == "" || mtxtDataCasamento.Text == "  /  /" || mtxtDataRegistro.Text == "  /  /")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos para a inserção do registro", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //METODO PARA INCLUSÃO NO BANCO DE DADOS
            con.AbrirCon();
            sql = "INSERT INTO casamento(nomeC1, dataC1, cpfC1, nomePC1, dataPC1, cpfPC1, nomeMC1, dataMC1, cpfMC1, nomeC2, dataC2, cpfC2, nomePC2, dataPC2, cpfPC2, nomeMC2, dataMC2, cpfMC2, dataR, dataC) VALUES (@txtNomeC1,@mtxtDataC1,@mtxtCPFC1,@txtNomePC1,@mtxtDataPC1,@mtxtCPFPC1,@txtNomeMC1,@mtxtDataMC1,@mtxtCPFMC1,@txtNomeC2,@mtxtDataC2,@mtxtCPFC2,@txtNomePC2,@mtxtDataPC2,@mtxtCPFPC2,@txtNomeMC2,@mtxtDataMC2,@mtxtCPFMC2,@mtxtDataRegistro,@mtxtDataCasamento)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("txtNomeC1", txtNomeC1.Text);
            DateTime NC1data = Convert.ToDateTime(mtxtDataC1.Text);
            cmd.Parameters.Add("@mtxtDataC1", MySqlDbType.Date).Value = NC1data;
            cmd.Parameters.AddWithValue("mtxtCPFC1", mtxtCPFC1.Text);
            cmd.Parameters.AddWithValue("txtNomePC1", txtNomePC1.Text);
            DateTime NPC1data = Convert.ToDateTime(mtxtDataPC1.Text);
            cmd.Parameters.Add("@mtxtDataPC1", MySqlDbType.Date).Value = NPC1data;
            cmd.Parameters.AddWithValue("mtxtCPFPC1", mtxtCPFPC1.Text);
            cmd.Parameters.AddWithValue("txtNomeMC1", txtNomeMC1.Text);
            DateTime NMC1data = Convert.ToDateTime(mtxtDataMC1.Text);
            cmd.Parameters.Add("@mtxtDataMC1", MySqlDbType.Date).Value = NMC1data;
            cmd.Parameters.AddWithValue("mtxtCPFMC1", mtxtCPFMC1.Text);
            cmd.Parameters.AddWithValue("txtNomeC2", txtNomeC2.Text);
            DateTime NC2data = Convert.ToDateTime(mtxtDataC2.Text);
            cmd.Parameters.Add("@mtxtDataC2", MySqlDbType.Date).Value = NC2data;
            cmd.Parameters.AddWithValue("mtxtCPFC2", mtxtCPFC2.Text);
            cmd.Parameters.AddWithValue("txtNomePC2", txtNomePC2.Text);
            DateTime NPC2data = Convert.ToDateTime(mtxtDataPC2.Text);
            cmd.Parameters.Add("@mtxtDataPC2", MySqlDbType.Date).Value = NPC2data;
            cmd.Parameters.AddWithValue("mtxtCPFPC2", mtxtCPFPC2.Text);
            cmd.Parameters.AddWithValue("txtNomeMC2", txtNomeMC2.Text);
            DateTime NMC2data = Convert.ToDateTime(mtxtDataMC2.Text);
            cmd.Parameters.Add("@mtxtDataMC2", MySqlDbType.Date).Value = NMC2data;
            cmd.Parameters.AddWithValue("mtxtCPFMC2", mtxtCPFMC2.Text);
            DateTime Rdata = Convert.ToDateTime(mtxtDataRegistro.Text);
            cmd.Parameters.Add("@mtxtDataRegistro", MySqlDbType.Date).Value = Rdata;
            DateTime Cdata = Convert.ToDateTime(mtxtDataCasamento.Text);
            cmd.Parameters.Add("@mtxtDataCasamento", MySqlDbType.Date).Value = Cdata;
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
