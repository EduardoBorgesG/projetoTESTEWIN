using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTESTEWIN
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nascimento.NascimentoTela form = new Nascimento.NascimentoTela();
            form.Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nascimento.TelaGerarRelatorio form = new Nascimento.TelaGerarRelatorio();
            form.Show();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Casamento.Casamento form = new Casamento.Casamento();
            form.Show();
        }

        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Obito.Obito form = new Obito.Obito();
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que desja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
           
        }

        
    }
}
