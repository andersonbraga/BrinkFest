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
        private IRepositorioTema repositorioTema2;
        private Tema temaSelecionado;
        private List<Tema> temas;

        public TelaCadastroItemTemaForm(List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            CarregarTemas(temas);
            //ConfigurarTela(temas);


        }


        private void CarregarTemas(List<Tema> temas2)
        {
            foreach (Tema tema in temas2)
            {
                cmbTema.Items.Add(tema);
            }
        }

        //public Tema ObterTema()
        //{
        //    cmbTema.Text = tema;
        //}

        private void ConfigurarTela(Tema tema)
        {

            cmbTema.Text = tema.tema;
            txtId.Text = tema.id.ToString();
            txtNovoItem.Text = tema.tema;


            listItens.Items.AddRange(tema.items.ToArray());


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoItem = txtNovoItem.Text;
            decimal novoValor = Convert.ToDecimal(txtValor.Text);

            Item itemTema = new Item(novoItem, novoValor);


            listItens.Items.Add(itemTema);


        }

        public List<Item> ObterItensCadastrados()
        {
            return listItens.Items.Cast<Item>().ToList();
        }
    }
}
