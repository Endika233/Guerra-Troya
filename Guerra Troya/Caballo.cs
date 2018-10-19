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
        private List<Griego> ocupantes; 
        private List<Troyano> ocupantesTroya = new List<Troyano>();

        public Caballo(int capacidad,List<Griego>ocupantes)
        {
            if (capacidad <= ocupantes.Count())
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
        public List<Griego> SetOcupante(Griego griego)//Meter objeto griego a lista ocupantes si hay sitio y actualizar ocupacion.Mostrar:Guerrero Griego 'nombre' montado en el caballo
        {
            if(capacidad > ocupantes.Count())
            {
                ocupantes.Add(griego);
                ocupacion = ocupantes.Count();
                Console.WriteLine("Guerrero Griego "+griego.GetNombre()+"montado en el caballo");
            }
            else if (capacidad <= ocupantes.Count())
            {
                Console.WriteLine("No queda sitio en el caballo");
            }
            else
            {
                Console.WriteLine("Algo raro has hecho tío, mira la clase caballo método SetOcupante");//TODO
            }
            return ocupantes;
        }
        public List<Troyano> SetOcupante(Troyano troyano)
        {
            Console.WriteLine("¡¡ATENCIÖN!! Guerrero Troyano " + troyano.GetNombre() + " intentando acceder al caballo, procedemos a su ejecución");
            troyano.SetMuerto(true);
            ocupantesTroya.Add(troyano);
            return ocupantesTroya;
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
        public void MostrarCaballo()
        {
            Console.WriteLine("Caballo con capacidad para "+capacidad+" guerreros, con "+ocupacion+" combatientes en él\nDatos de los guerreros:\n");
            foreach (Griego persona in ocupantes)
            {
                persona.ShowAll();
            }
        }

    }
}

