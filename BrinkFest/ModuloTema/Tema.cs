using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase <Tema>
    {
        public string titulo;
        public string item;
        public int quantidade;
        public decimal valor;

        public Tema() 
        {
            
        }
        public Tema(string titulo, string item, int quantidade, decimal valor)
        {
            this.titulo = titulo;
            this.item = item;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.titulo = registroAtualizado.titulo;
            this.item = registroAtualizado.item;
            this.quantidade = registroAtualizado.quantidade;
            this.valor = registroAtualizado.valor;
        }

        public override string ToString()
        {
            return $"titulo {titulo}, item {item}, quantidade {quantidade}, valor {valor}";
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
            {
                erros.Add("O campo ''Tema'' é obrigatório");
            }
            if (string.IsNullOrEmpty(item))
            {
                erros.Add("O campo ''Item'' é obrigatório");
            }
            if (quantidade < 0)
            {
                erros.Add("O campo ''Quantidade'' é obrigatório");
            }
            if (valor < 0)
            {
                erros.Add("O campo ''Valor'' é obrigatório");
            }

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Tema tema &&
                id == tema.id &&
                titulo == tema.titulo &&
                item == tema.item &&
                quantidade == tema.quantidade &&
                valor == tema.valor;
        }
    }
}
