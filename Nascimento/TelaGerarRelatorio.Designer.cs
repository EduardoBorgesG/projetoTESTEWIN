namespace projetoTESTEWIN.Nascimento
{
    partial class TelaGerarRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.mtxtDataI = new System.Windows.Forms.MaskedTextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.mtxtDataF = new System.Windows.Forms.MaskedTextBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(29, 31);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 13);
            this.lblData.TabIndex = 999;
            this.lblData.Text = "Data inicial";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(33, 259);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(161, 29);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "GERAR RELATÓRIO";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // mtxtDataI
            // 
            this.mtxtDataI.Location = new System.Drawing.Point(94, 28);
            this.mtxtDataI.Mask = "00/00/0000";
            this.mtxtDataI.Name = "mtxtDataI";
            this.mtxtDataI.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataI.TabIndex = 1;
            this.mtxtDataI.ValidatingType = typeof(System.DateTime);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(200, 31);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 999;
            this.lblA.Text = "a";
            // 
            // mtxtDataF
            // 
            this.mtxtDataF.Location = new System.Drawing.Point(219, 28);
            this.mtxtDataF.Mask = "00/00/0000";
            this.mtxtDataF.Name = "mtxtDataF";
            this.mtxtDataF.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataF.TabIndex = 2;
            this.mtxtDataF.ValidatingType = typeof(System.DateTime);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(277, 259);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(161, 29);
            this.btnXML.TabIndex = 1000;
            this.btnXML.Text = "GERAR XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 65);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(472, 150);
            this.grid.TabIndex = 1001;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(363, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 23);
            this.btnPesquisar.TabIndex = 1002;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // TelaGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 323);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.mtxtDataF);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.mtxtDataI);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblData);
            this.Name = "TelaGerarRelatorio";
            this.Text = "Gerar Relatorio";
            this.Load += new System.EventHandler(this.TelaGerarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.MaskedTextBox mtxtDataI;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.MaskedTextBox mtxtDataF;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnPesquisar;
    }
}