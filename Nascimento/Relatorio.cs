using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace projetoTESTEWIN.Nascimento
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nascimentoTableAdapter.Fill(this.projetowinDataSet1.nascimento, Convert.ToDateTime(Program.DataInicial), Convert.ToDateTime(Program.DataFinal));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", Program.DataInicial));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", Program.DataFinal));
            this.reportViewer1.RefreshReport();
        }


    }
}
