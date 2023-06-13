namespace BrinkFest.WinApp.ModuloTema
{
    partial class TabelaTemaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataTemas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataTemas).BeginInit();
            SuspendLayout();
            // 
            // dataTemas
            // 
            dataTemas.BackgroundColor = SystemColors.GradientActiveCaption;
            dataTemas.BorderStyle = BorderStyle.Fixed3D;
            dataTemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTemas.Dock = DockStyle.Fill;
            dataTemas.GridColor = SystemColors.InactiveBorder;
            dataTemas.Location = new Point(0, 0);
            dataTemas.Name = "dataTemas";
            dataTemas.RowTemplate.Height = 25;
            dataTemas.Size = new Size(150, 150);
            dataTemas.TabIndex = 0;
            // 
            // TabelaTemaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataTemas);
            Name = "TabelaTemaControl";
            ((System.ComponentModel.ISupportInitialize)dataTemas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataTemas;
    }
}
