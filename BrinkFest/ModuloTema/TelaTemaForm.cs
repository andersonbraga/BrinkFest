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
            this.ConfigurarDialog();
        }
        public Tema ObterTema()
        {
            string titulo = txtTitulo.Text;
            string item = txtItem.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal valor = Convert.ToDecimal(txtValor.Text);

            Tema tema = new Tema(titulo, item, quantidade, valor);

            return tema;
        }
        public void ConfigurarTela(Tema tema)
        {
            txtID.Text = tema.id.ToString();
            txtTitulo.Text = tema.titulo;
            txtItem.Text = tema.item;
            txtQuantidade.Text = tema.quantidade.ToString();
            txtValor.Text = tema.valor.ToString();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
