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
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace projetoTESTEWIN.Nascimento
{
    public partial class TelaGerarRelatorio : Form
    {
        DataTable dt = new DataTable("nascimento");
        Conec con = new Conec();
        string sql;
        MySqlCommand cmd;
        

        public TelaGerarRelatorio()
        {
            InitializeComponent();
        }
        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "Registrado";
            grid.Columns[1].Visible = false;
            grid.Columns[2].Visible = false;
            grid.Columns[3].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[5].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].HeaderText = "Data Registro";

        }
        private void BuscarDG()
        {
            //METODO PARA BUSCAR OS REGISTROS POR DATA
            con.AbrirCon();
            sql = "SELECT nomeR, dataNRda, nomeM, dataNM, cpfM, nomeP, dataNP, cpfP, dataR FROM nascimento WHERE dataR >= @dataI AND dataR <= @dataF";
            cmd = new MySqlCommand(sql, con.con);
            DateTime dataI = Convert.ToDateTime(mtxtDataI.Text);
            cmd.Parameters.Add("@dataI", MySqlDbType.DateTime).Value = dataI;
            DateTime dataF = Convert.ToDateTime(mtxtDataF.Text);
            cmd.Parameters.Add("@dataF", MySqlDbType.DateTime).Value = dataF;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grid.DataSource = dt;

        }
        private void GerarXml()
        {
            //Metodo para gerar o arquivo XML
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            caminho = Path.Combine(caminho, String.Format("Relatorio_{0}.XML", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")));
            dt.WriteXml(caminho, XmlWriteMode.WriteSchema);
            string mensagem = "Arquivo gerado com sucess no caminho\n" + caminho;
            MessageBox.Show(mensagem,"Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DateTime DataInicial = Convert.ToDateTime(mtxtDataI.Text);
            Program.DataInicial = DataInicial.ToString();
            DateTime DataFinal = Convert.ToDateTime(mtxtDataF.Text);
            Program.DataFinal = DataFinal.ToString();
            Nascimento.frmRelatorio form = new Nascimento.frmRelatorio();
            form.Show();
        }

        private void TelaGerarRelatorio_Load(object sender, EventArgs e)
        {
            btnGerar.Enabled = false;
            btnXML.Enabled = false;
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            GerarXml();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarDG();
            FormatarDG();
            btnGerar.Enabled = true;
            btnXML.Enabled = true;
        }
    }
}
