using BrinkFest.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }

        public override string ToolTipEditar { get { return "Editar  Tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir  Tema existente"; } }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            
            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Inserir(tema);

                MessageBox.Show("Inserção completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Inserção Cancelada!");
            }
        }
        public override void Editar()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Selecione um Tema!", "Edição de Temas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            TelaTemaForm telaTema = new TelaTemaForm();

            telaTema.ConfigurarTela(tema);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema temaAtualizado = telaTema.ObterTema();

                repositorioTema.Editar(temaAtualizado.id, temaAtualizado);

                MessageBox.Show("Edição completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Edição Cancelada!");
            }
        }
        public override void Excluir()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Selecione um Tema!", "Exclusão de Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o Tema {tema.titulo} ?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(tema);

                MessageBox.Show("Exclusão completa!");

                CarregarTema();
            }
            else if (opcaoEscolhida == DialogResult.Cancel)
            {
                MessageBox.Show("Exclusão Cancelada!");
            }
        }
        public void CarregarTema()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }
        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTema.ObterIdSelecionado();
            return repositorioTema.SelecionarPorId(id);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
            {
                tabelaTema = new TabelaTemaControl();
            }

            CarregarTema();

            return tabelaTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
    }
}