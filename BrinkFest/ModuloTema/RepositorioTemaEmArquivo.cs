using BrinkFest.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioEmArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }


        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.temas;
        }
    }
}
