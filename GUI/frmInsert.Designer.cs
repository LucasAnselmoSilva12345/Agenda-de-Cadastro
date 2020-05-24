namespace GUI
{
    partial class frmInsert
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbFixo = new System.Windows.Forms.RadioButton();
            this.rbCelular = new System.Windows.Forms.RadioButton();
            this.gbTelefone = new System.Windows.Forms.GroupBox();
            this.pnDados = new System.Windows.Forms.Panel();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btNav = new System.Windows.Forms.Button();
            this.btNote = new System.Windows.Forms.Button();
            this.btCalc = new System.Windows.Forms.Button();
            this.btCEP = new System.Windows.Forms.Button();
            this.btFrmBackup = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbTelefone.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(126, 11);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(573, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(573, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // rbFixo
            // 
            this.rbFixo.AutoSize = true;
            this.rbFixo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbFixo.Location = new System.Drawing.Point(15, 26);
            this.rbFixo.Name = "rbFixo";
            this.rbFixo.Size = new System.Drawing.Size(44, 17);
            this.rbFixo.TabIndex = 8;
            this.rbFixo.TabStop = true;
            this.rbFixo.Text = "Fixo";
            this.rbFixo.UseVisualStyleBackColor = true;
            this.rbFixo.CheckedChanged += new System.EventHandler(this.rbFixo_CheckedChanged);
            // 
            // rbCelular
            // 
            this.rbCelular.AutoSize = true;
            this.rbCelular.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCelular.Location = new System.Drawing.Point(123, 28);
            this.rbCelular.Name = "rbCelular";
            this.rbCelular.Size = new System.Drawing.Size(57, 17);
            this.rbCelular.TabIndex = 9;
            this.rbCelular.TabStop = true;
            this.rbCelular.Text = "Celular";
            this.rbCelular.UseVisualStyleBackColor = true;
            this.rbCelular.CheckedChanged += new System.EventHandler(this.rbCelular_CheckedChanged);
            // 
            // gbTelefone
            // 
            this.gbTelefone.BackColor = System.Drawing.Color.Transparent;
            this.gbTelefone.Controls.Add(this.rbFixo);
            this.gbTelefone.Controls.Add(this.rbCelular);
            this.gbTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbTelefone.Location = new System.Drawing.Point(126, 132);
            this.gbTelefone.Name = "gbTelefone";
            this.gbTelefone.Size = new System.Drawing.Size(200, 69);
            this.gbTelefone.TabIndex = 10;
            this.gbTelefone.TabStop = false;
            this.gbTelefone.Text = "Tipo";
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.Color.Transparent;
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.gbTelefone);
            this.pnDados.Location = new System.Drawing.Point(19, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(753, 267);
            this.pnDados.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(379, 160);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(212, 20);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // btNav
            // 
            this.btNav.Image = global::GUI.Properties.Resources.chrome;
            this.btNav.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNav.Location = new System.Drawing.Point(566, 476);
            this.btNav.Name = "btNav";
            this.btNav.Size = new System.Drawing.Size(75, 74);
            this.btNav.TabIndex = 22;
            this.btNav.Text = "Navegador";
            this.btNav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNav.UseVisualStyleBackColor = true;
            this.btNav.Click += new System.EventHandler(this.btNav_Click);
            // 
            // btNote
            // 
            this.btNote.Image = global::GUI.Properties.Resources.notepad;
            this.btNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNote.Location = new System.Drawing.Point(455, 476);
            this.btNote.Name = "btNote";
            this.btNote.Size = new System.Drawing.Size(75, 74);
            this.btNote.TabIndex = 21;
            this.btNote.Text = "Bloco de Notas";
            this.btNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNote.UseVisualStyleBackColor = true;
            this.btNote.Click += new System.EventHandler(this.btNote_Click);
            // 
            // btCalc
            // 
            this.btCalc.Image = global::GUI.Properties.Resources.calculadora;
            this.btCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCalc.Location = new System.Drawing.Point(337, 476);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(75, 74);
            this.btCalc.TabIndex = 20;
            this.btCalc.Text = "Calculadora";
            this.btCalc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btCEP
            // 
            this.btCEP.Image = global::GUI.Properties.Resources.location;
            this.btCEP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCEP.Location = new System.Drawing.Point(214, 476);
            this.btCEP.Name = "btCEP";
            this.btCEP.Size = new System.Drawing.Size(75, 74);
            this.btCEP.TabIndex = 19;
            this.btCEP.Text = "Pesquisa CEP";
            this.btCEP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCEP.UseVisualStyleBackColor = true;
            this.btCEP.Click += new System.EventHandler(this.btCEP_Click);
            // 
            // btFrmBackup
            // 
            this.btFrmBackup.Image = global::GUI.Properties.Resources.backup;
            this.btFrmBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFrmBackup.Location = new System.Drawing.Point(89, 476);
            this.btFrmBackup.Name = "btFrmBackup";
            this.btFrmBackup.Size = new System.Drawing.Size(75, 74);
            this.btFrmBackup.TabIndex = 18;
            this.btFrmBackup.Text = "Backup / Restore";
            this.btFrmBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFrmBackup.UseVisualStyleBackColor = true;
            this.btFrmBackup.Click += new System.EventHandler(this.btFrmBackup_Click);
            // 
            // btCancela
            // 
            this.btCancela.Image = global::GUI.Properties.Resources.cancelar1;
            this.btCancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancela.Location = new System.Drawing.Point(625, 372);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 69);
            this.btCancela.TabIndex = 16;
            this.btCancela.Text = "Cancelar";
            this.btCancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSalvar.ForeColor = System.Drawing.Color.Black;
            this.btSalvar.Image = global::GUI.Properties.Resources.salvar1;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.Location = new System.Drawing.Point(499, 372);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 69);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::GUI.Properties.Resources.excluir1;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(268, 372);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 69);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::GUI.Properties.Resources.alterar1;
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlterar.Location = new System.Drawing.Point(145, 372);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 69);
            this.btAlterar.TabIndex = 13;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = global::GUI.Properties.Resources.localizar1;
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLocalizar.Location = new System.Drawing.Point(40, 372);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 69);
            this.btLocalizar.TabIndex = 12;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Image = global::GUI.Properties.Resources.add1;
            this.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdicionar.Location = new System.Drawing.Point(385, 372);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 69);
            this.btAdicionar.TabIndex = 11;
            this.btAdicionar.Text = "&Adicionar";
            this.btAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // frmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btNav);
            this.Controls.Add(this.btNote);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.btCEP);
            this.Controls.Add(this.btFrmBackup);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.btAdicionar);
            this.Name = "frmInsert";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmInsert_Load);
            this.gbTelefone.ResumeLayout(false);
            this.gbTelefone.PerformLayout();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbFixo;
        private System.Windows.Forms.RadioButton rbCelular;
        private System.Windows.Forms.GroupBox gbTelefone;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btFrmBackup;
        private System.Windows.Forms.Button btCEP;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btNote;
        private System.Windows.Forms.Button btNav;
    }
}

