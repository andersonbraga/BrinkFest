using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkFest.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
        }
        private Tema tema;

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string titulo = txtTitulo.Text;
            string item = txtItem.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal valor = Convert.ToDecimal(txtValor.Text);

            tema = new Tema(titulo, item, quantidade, valor);
        }

        public Tema Tema
        {
            get
            {
                return tema;
            }
            set
            {

            }
        }
    }
}
