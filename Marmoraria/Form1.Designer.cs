namespace Marmoraria
{
    partial class FrmCadastroClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            label1 = new Label();
            textBoxNome = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            textBoxCidade = new TextBox();
            label2 = new Label();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxRua = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBoxCodigo = new TextBox();
            textBoxDocumento = new MaskedTextBox();
            textBoxTelefone = new MaskedTextBox();
            OpCNPJ = new RadioButton();
            OpCPF = new RadioButton();
            textBoxObs = new TextBox();
            btSalvar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click_1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 43);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(438, 26);
            textBoxNome.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 4;
            label4.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 81);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 6;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 340);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 7;
            label7.Text = "Observações";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxCidade);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxBairro);
            groupBox2.Controls.Add(textBoxNumero);
            groupBox2.Controls.Add(textBoxRua);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 147);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(334, 105);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(110, 26);
            textBoxCidade.TabIndex = 10;
            textBoxCidade.Text = "Tatuí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 9;
            label2.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(6, 105);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(322, 26);
            textBoxBairro.TabIndex = 5;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(334, 51);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(110, 26);
            textBoxNumero.TabIndex = 4;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(6, 51);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(322, 26);
            textBoxRua.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 30);
            label8.Name = "label8";
            label8.Size = new Size(31, 18);
            label8.TabIndex = 2;
            label8.Text = "Rua";
            label8.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(334, 30);
            label9.Name = "label9";
            label9.Size = new Size(23, 18);
            label9.TabIndex = 3;
            label9.Text = "N°";
            label9.Click += label9_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxCodigo);
            groupBox1.Controls.Add(textBoxDocumento);
            groupBox1.Controls.Add(textBoxTelefone);
            groupBox1.Controls.Add(OpCNPJ);
            groupBox1.Controls.Add(OpCPF);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Pessoais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 83);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 15;
            label3.Text = "Código";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(363, 102);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(78, 26);
            textBoxCodigo.TabIndex = 5;
            textBoxCodigo.TabStop = false;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(117, 102);
            textBoxDocumento.Mask = "000,000,000-00";
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(105, 26);
            textBoxDocumento.TabIndex = 4;
            textBoxDocumento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(6, 102);
            textBoxTelefone.Mask = "(00) 00000-0000";
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(105, 26);
            textBoxTelefone.TabIndex = 2;
            textBoxTelefone.Text = "15";
            textBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // OpCNPJ
            // 
            OpCNPJ.AutoSize = true;
            OpCNPJ.Location = new Point(166, 79);
            OpCNPJ.Name = "OpCNPJ";
            OpCNPJ.Size = new Size(56, 22);
            OpCNPJ.TabIndex = 100;
            OpCNPJ.Text = "CNPJ";
            OpCNPJ.UseVisualStyleBackColor = true;
            // 
            // OpCPF
            // 
            OpCPF.AutoSize = true;
            OpCPF.Checked = true;
            OpCPF.Location = new Point(117, 79);
            OpCPF.Name = "OpCPF";
            OpCPF.Size = new Size(49, 22);
            OpCPF.TabIndex = 3;
            OpCPF.TabStop = true;
            OpCPF.Text = "CPF";
            OpCPF.UseVisualStyleBackColor = true;
            // 
            // textBoxObs
            // 
            textBoxObs.Location = new Point(12, 361);
            textBoxObs.Multiline = true;
            textBoxObs.Name = "textBoxObs";
            textBoxObs.Size = new Size(444, 86);
            textBoxObs.TabIndex = 11;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = SystemColors.MenuHighlight;
            btSalvar.FlatAppearance.BorderSize = 0;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Image = (Image)resources.GetObject("btSalvar.Image");
            btSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btSalvar.Location = new Point(375, 453);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(81, 36);
            btSalvar.TabIndex = 12;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.MiddleRight;
            btSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += button1_Click;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 501);
            Controls.Add(btSalvar);
            Controls.Add(textBoxObs);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += Form1_Load;
            KeyDown += FrmCadastroClientes_KeyDown;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label4;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private TextBox textBoxNumero;
        private TextBox textBoxRua;
        private TextBox textBoxCidade;
        private Label label2;
        private TextBox textBoxBairro;
        private GroupBox groupBox2;
        private TextBox textBoxObs;
        private RadioButton OpCPF;
        private MaskedTextBox textBoxDocumento;
        private MaskedTextBox textBoxTelefone;
        private Button btSalvar;
        private Label label3;
        private TextBox textBoxCodigo;
        private RadioButton OpCNPJ;
    }
}
