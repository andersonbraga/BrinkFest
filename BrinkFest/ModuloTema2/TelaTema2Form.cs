using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkFest.WinApp.ModuloTema2
{
    public partial class TelaTema2Form : Form
    {
        public TelaTema2Form()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }
        public Tema2 ObterTema2()
        {
            int id = Convert.ToInt32(txtId.Text);

            string tema2 = txtTema2.Text;

            return new Tema2(id, tema2);
        }
        public void ConfigurarTela(Tema2 tema2)
        {
            txtId.Text = tema2.id.ToString();

            txtTema2.Text = tema2.tema2;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema2 tema2 = ObterTema2();

            string[] erros = tema2.Validar();

            if (erros.Count() > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
