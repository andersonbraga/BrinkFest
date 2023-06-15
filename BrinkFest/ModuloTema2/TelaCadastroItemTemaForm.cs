using BrinkFest.WinApp.ModuloCliente;
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
    public partial class TelaCadastroItemTemaForm : Form
    {
        public TelaCadastroItemTemaForm(Tema2 temas2)
        {
            InitializeComponent();

            this.ConfigurarDialog();
          
            ConfigurarTela(temas2);

        }

        //private void CarregarTemas(List<Tema2> temas2)
        //{
        //    foreach (Tema2 tema2 in temas2)
        //    {
        //        cmbTema.Items.Add(tema2);
        //    }
        //}

        private void ConfigurarTela(Tema2 tema2)
        {
            txtId.Text = tema2.id.ToString();
            txtNovoItem.Text = tema2.tema2;

            listItens.Items.AddRange(tema2.items.ToArray());

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoItem = txtNovoItem.Text;

            Item itemTema = new Item(novoItem);

            listItens.Items.Add(itemTema);
        }

        public List<Item> ObterItensCadastrados()
        {
            return listItens.Items.Cast<Item>().ToList();
        }
    }
}
