using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.Compartilhado
{
<<<<<<< HEAD
    public abstract class EntidadeBase<TEntidade>
    {
        public int id { get; set; }
=======
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

>>>>>>> ee1bedced062427ed7f40871c4b1e0e71f4fb7aa
        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);

        public abstract string[] Validar();
    }
}
