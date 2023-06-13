using BrinkFest.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioEmArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }


        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}
