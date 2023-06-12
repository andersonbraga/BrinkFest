namespace BrinkFest.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            btnGravar = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(352, 384);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(433, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(28, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 349);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Itens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Número: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 46);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Item: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 76);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 109);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Tema: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 76);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(335, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(89, 109);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 202);
            checkedListBox1.TabIndex = 10;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 419);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnGravar);
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Itens";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGravar;
        private Button btnCancel;
        private Panel panel1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}