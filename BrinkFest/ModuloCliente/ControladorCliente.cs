﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public override string ToolTipInserir { get { return "Inserir novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente Existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente Existente"; } }

        public override void Editar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null )
            {
                MessageBox.Show($"Selecione um Cliente primeiro!", "Edição de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TelaClienteForm telaCliente = new TelaClienteForm();
            telaCliente.ConfigurarTela(cliente);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) 
            {
                Cliente clienteAtualizado = telaCliente.ObterCliente();
                repositorioCliente.Editar(clienteAtualizado.id, clienteAtualizado);

                CarregarClientes();
            }

        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            tabelaCliente.AtualizarRegistros(clientes);
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um Cliente primeiro!", "Exclusão de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Cliente {cliente.nome}?", "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);

                CarregarClientes();
            }
        }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();
            DialogResult opcaoEscolhida = telaCliente.ShowDialog();
           
            if (opcaoEscolhida == DialogResult.OK )
            {
                Cliente cliente = telaCliente.ObterCliente();
                repositorioCliente.Inserir(cliente);

                CarregarClientes();
            }
        }

        public override UserControl ObterListagem()
        {
           if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

           CarregarClientes();
            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }
    }
}
