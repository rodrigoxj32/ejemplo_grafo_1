using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_grafo_1
{
    public class Vertice
    {
        public int value { get; set; }
        public List<Vertice> aristas { get; set; }

        public Boolean isPrint { get; set; }

        public Vertice(int value)
        {
            this.value = value;
            aristas = new List<Vertice>();
        }

        public int getCountAristas()
        {
            return aristas.Count;
        }
    }
}
