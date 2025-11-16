namespace Marmoraria
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox8 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 26);
            textBox1.TabIndex = 1;
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
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 147);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(334, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 26);
            textBox5.TabIndex = 10;
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
            // textBox4
            // 
            textBox4.Location = new Point(6, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 26);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 26);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 26);
            textBox2.TabIndex = 3;
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
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 152);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Pessoais";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(117, 102);
            maskedTextBox2.Mask = "000,000,000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(105, 26);
            maskedTextBox2.TabIndex = 13;
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 102);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(105, 26);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(166, 79);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 22);
            radioButton2.TabIndex = 10;
            radioButton2.Text = "CNPJ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(117, 79);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 22);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "CPF";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 361);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(444, 86);
            textBox8.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 501);
            Controls.Add(textBox8);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox5;
        private Label label2;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private TextBox textBox8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
    }
}
