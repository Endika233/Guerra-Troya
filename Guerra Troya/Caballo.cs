using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra_Troya
{
    class Caballo
    {
        private int capacidad,ocupacion;
        private List<Griego> ocupantes = new List<Griego>();

        public Caballo(int capacidad,List<Griego>ocupantes)
        {
            if (capacidad < ocupantes.Count())
            {
                Console.WriteLine("No puede haber más ocupantes que capacidad tiene el caballo");
            }
            else
            {
                this.capacidad = capacidad;
                this.ocupantes = ocupantes;
                this.ocupacion = ocupantes.Count();
            }          
        }
        public int Buscar(string nombre)
        {           
            foreach(Griego ocupante in ocupantes)
            {
                if (ocupante.GetNombre() == nombre)
                {
                    return ocupantes.IndexOf(ocupante);
                }
            }
            return -1;
        }
        public void MostrarGuerreroPosicion(int posicion)
        {
            posicion = posicion - 1;
            try
            {
                ocupantes.ElementAt(posicion).ShowAll();//Primero me encuentra el objeto y luego ejecuta ShowAll
            }
            catch
            {
                Console.WriteLine("No ha sido posible encontrar al guerrero en la posicion especificada");
            }
        }

    }
}
//e) Crear un método MontarseEnCaballo(guerrero) que reciba como parámetro un guerrero, compruebe que es Griego y lo 
//meta en el array de ocupantes(si hay sitio). Si el que quiere montarse es Troyano se mostrará el siguiente mensaje y matarlo:
