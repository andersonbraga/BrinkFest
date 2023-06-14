namespace BrinkFest.WinApp.ModuloTema2
{
    partial class TelaTema2Form
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
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtTema2 = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 34);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Tema:";
            // 
            // txtId
            // 
            txtId.Location = new Point(83, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 2;
            // 
            // txtTema2
            // 
            txtTema2.Location = new Point(269, 26);
            txtTema2.Name = "txtTema2";
            txtTema2.Size = new Size(297, 23);
            txtTema2.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(100, 117);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(103, 52);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(476, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 52);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTema2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 193);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTema2);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTema2Form";
            Text = "TeleTema2Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtTema2;
        private Button btnGravar;
        private Button btnCancelar;
    }
}