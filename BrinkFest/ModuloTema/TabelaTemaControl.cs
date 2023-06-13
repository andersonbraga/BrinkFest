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
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            dataTemas.ConfigurarGridZebrado();

            dataTemas.ConfigurarGridSomenteLeitura();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "item",
                    HeaderText = "Item"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "quantidade",
                    HeaderText = "Quantidade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                }
            };

            dataTemas.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            dataTemas.Rows.Clear();

            foreach (Tema tema in temas)
            {
                dataTemas.Rows.Add(tema.id, tema.titulo, tema.item, tema.quantidade, tema.valor);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(dataTemas.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }

    }
}
