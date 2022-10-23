using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejemplo_grafo_1
{
    class EjemploGrafo1
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(1);
            Vertice v2 = new Vertice(2);
            Vertice v3 = new Vertice(3);
            Vertice v4 = new Vertice(4);
            Vertice v5 = new Vertice(5);
            Vertice v6 = new Vertice(6);

            v6.aristas.Add(v4);

            v4.aristas.Add(v5);
            v4.aristas.Add(v3);

            v5.aristas.Add(v1);
            v5.aristas.Add(v2);

            v3.aristas.Add(v2);

            v2.aristas.Add(v1);

            Camino(v6);
        }


        private static void Camino(Vertice vertice, string sangria = "")
        {
            if(vertice != null)
            {
                String sangriaNew = "";
                if (vertice.getCountAristas() > 1)
                {
                    sangriaNew = "\t";
                }


                if (vertice.isPrint == false)
                {
                    Console.WriteLine(sangria + vertice.value);
                    vertice.isPrint = true;
                }


                foreach (var ver in vertice.aristas)
                {
                    Camino(ver, sangria + sangriaNew);
                }
            }
            
        }


        private static Vertice? createVertice(int value)
        {
            try
            {
                Vertice vertice = new Vertice(value);
                return vertice;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private static Vertice? createVertice(ref int value)
        {
            try
            {
                Vertice vertice = new Vertice(value);
                return vertice;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }


}

