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
            txtTitulo = new TextBox();
            txtValor = new TextBox();
            txtQuantidade = new TextBox();
            txtItem = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            btnGravar.Click += btnGravar_Click;
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
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(txtItem);
            panel1.Controls.Add(txtID);
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
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 45);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(364, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(335, 104);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(118, 23);
            txtValor.TabIndex = 9;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(89, 104);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 8;
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(89, 74);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(364, 23);
            txtItem.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 16);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 23);
            txtID.TabIndex = 6;
            txtID.Text = "0";
            txtID.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 107);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 48);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Tema: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 107);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 77);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Item: ";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Itens";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
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
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private TextBox txtItem;
        private TextBox txtTitulo;
    }
}