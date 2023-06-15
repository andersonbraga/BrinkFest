using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    public class RepositorioTema2EmArquivo : RepositorioEmArquivoBase<Tema2>, IRepositorioTema2
    {
        public RepositorioTema2EmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Tema2> ObterRegistros()
        {
            return contextoDados.tema2;
        }
    }
}
