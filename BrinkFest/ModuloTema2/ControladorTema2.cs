
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    public class ControladorTema2 : ControladorBase
    {
        private IRepositorioTema2 repositorioTema2;
        private TabelaTema2Control tabelaTema2;

        public ControladorTema2(IRepositorioTema2 repositorioTema2)
        {
            this.repositorioTema2 = repositorioTema2;
        }

        #region tooltips
        public override string ToolTipInserir => "Inserir nova Tema";

        public override string ToolTipEditar => "Editar Tema existente";

        public override string ToolTipExcluir => "Excluir Tema existente";

        public override string ToolTipFiltrar => "Filtrar Tema";

        public override string ToolTipAdicionarItens => "Adicionar Itens na Tema";

        public override string ToolTipConcluirItens => "Concluir Itens da Tema";

        #endregion

        public override bool FiltrarHabilitado => true;

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override void Inserir()
        {
            TelaTema2Form telaTema2 = new TelaTema2Form();

            DialogResult opcaoEscolhida = telaTema2.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema2 novaTema = telaTema2.ObterTema2();

                repositorioTema2.Inserir(novaTema);

            }
            CarregarTemas2();
        }

        public override void Editar()
        {
            Tema2 temaSelecionado = ObterTema2Selecionada();

            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Edição de Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaTema2Form telaTema2 = new TelaTema2Form();

            telaTema2.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema2.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema2 tema2 = telaTema2.ObterTema2();

                repositorioTema2.Editar(tema2.id, tema2);

            }
            CarregarTemas2();
        }

        public override void Excluir()
        {
            Tema2 temaSelecionado = ObterTema2Selecionada();

            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Exclusão de Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tema {temaSelecionado.tema2}?",
                "Exclusão de Tema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema2.Excluir(temaSelecionado);

                CarregarTemas2();
            }
        }

        public override void Adicionar()
        {
            Tema2 temaSelecionado = ObterTema2Selecionada();
         
 
            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Adição de Itens da tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroItemTemaForm telaCadastroItemTema = new TelaCadastroItemTemaForm(temaSelecionado);

            DialogResult opcaoEscolhida = telaCadastroItemTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Item> itensParaAdicionar = telaCadastroItemTema.ObterItensCadastrados();

                foreach (Item item in itensParaAdicionar)
                {
                    temaSelecionado.AdicionarItem(item);
                }

                repositorioTema2.Editar(temaSelecionado.id, temaSelecionado);
                CarregarTemas2();
            }
        }


        public override UserControl ObterListagem()
        {
            if (tabelaTema2 == null)
                tabelaTema2 = new TabelaTema2Control();

            CarregarTemas2();

            return tabelaTema2;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        private Tema2 ObterTema2Selecionada()
        {
            int id = tabelaTema2.ObterIdSelecionado();

            return repositorioTema2.SelecionarPorId(id);
        }

        private void CarregarTemas2()
        {
            List<Tema2> tema2 = repositorioTema2.SelecionarTodos();
            tabelaTema2.AtualizarTema2(tema2);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tema2.Count} tema(s)");
        }


    }
}
