using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    [Serializable]
    public class Item
    {
        public string item;
        public Tema2 tema;

        public Item () 
        {
            
        }

        public Item(string item)
        {
            this.item = item;
        }

        public Item(string item, Tema2 tema)
        {
            this.item = item;
          
        }

        public override string ToString()
        {
            return $"(Item: {item}  Tema: {tema})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Item itens && item == itens.item && tema == itens.tema;
                
        }
    }
}
