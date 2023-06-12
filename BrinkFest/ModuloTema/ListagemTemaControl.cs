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
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistro(List<Tema> temas)
        {
            listTema.Items.Clear();
            foreach (Tema item in temas)
            {
                listTema.Items.Add(item);
            }
        }
        public Tema ObterTemaSelecionado()
        {
            return (Tema)listTema.SelectedItem;
        }
    }
}
