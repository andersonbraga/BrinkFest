namespace BrinkFest.WinApp.ModuloTema2
{
    partial class TabelaTema2Control
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
            gridTema2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTema2).BeginInit();
            SuspendLayout();
            // 
            // gridTema2
            // 
            gridTema2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTema2.Dock = DockStyle.Fill;
            gridTema2.Location = new Point(0, 0);
            gridTema2.Name = "gridTema2";
            gridTema2.RowTemplate.Height = 25;
            gridTema2.Size = new Size(814, 368);
            gridTema2.TabIndex = 0;
            // 
            // TabelaTema2Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTema2);
            Name = "TabelaTema2Control";
            Size = new Size(814, 368);
            ((System.ComponentModel.ISupportInitialize)gridTema2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTema2;
    }
}
