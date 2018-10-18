using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra_Troya
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Troyano> listaTroyanos = new List<Troyano>();
            List<Griego> listaGriegos = new List<Griego>();
            listaGriegos.Add(CrearGriego("Aquiles",30,10));
            listaGriegos.Add(CrearGriego("Agamenon",29,9));
            listaGriegos.Add(CrearGriego("Ajax",28,8));

            Caballo caballo1 = new Caballo(20,listaGriegos);
            caballo1.MostrarCaballo();

            
            listaGriegos=caballo1.SetOcupante(CrearGriego());
            caballo1.MostrarCaballo();

            caballo1.Buscar("Agamenon");
            caballo1.Buscar("Odiseo");

            listaTroyanos=caballo1.SetOcupante(CrearToyano("Paris", 20, 10));
            foreach (Griego g in listaGriegos)
            {
                g.ShowAll();
            }
            foreach (Troyano t in listaTroyanos)
            {
                t.ShowAll();
            }


            Console.ReadLine();
//2.Crear un caballo con capacidad para 20 guerreros.
//3.Crear 3  guerreros griegos(Aquiles, Agamenon y Ajax) y montarlos en el caballo.
//4.Mostrar caballo.
//5.Crea otro guerrero griego anónimo y móntalo en el caballo y muestra el caballo.
//6.Buscar a Agamenon en el caballo y mostrar sus datos.
//7.Buscar  a Odiseo en el caballo y comprobar que no existe.
//8.Crear 1 guerrero troyano(Paris ).
//9.Montarlo en el caballo y comprobar que no es posible.
        }
        public static Troyano CrearToyano()
        {
            Troyano troyano = new Troyano();
            return troyano;
        }
        public static Griego CrearGriego()
        {
            Griego griego = new Griego();
            return griego;
        }
        public static Troyano CrearToyano(string nombre, int edad, int fuerza)
        {
            Troyano troyano = new Troyano(nombre,edad,fuerza);
            return troyano;
        }
        public static Griego CrearGriego(string nombre, int edad, int fuerza)
        {
            Griego griego = new Griego(nombre, edad, fuerza);
            return griego;
        }
        public static void Retirada(Troyano troyano, bool retirarse)
        {
            troyano.SetRetirarse(retirarse);
        }
        public static void Retirada(Griego griego, bool retirarse)
        {
            griego.SetRetirarse(retirarse);
        }
        public static bool ComprobarEdad(Troyano troyano)
        {
            if (troyano.GetEdad() > 14 || troyano.GetEdad() < 61)
            {
                return true;
            }
            return false;
        }
        public static bool ComprobarEdad(Griego griego)
        {
            if (griego.GetEdad() > 14 || griego.GetEdad() < 61)
            {
                return true;
            }
            return false;
        }
        public static bool ComprobarFuerza(Troyano troyano)
        {
            if (troyano.GetFuerza() > 0 && troyano.GetFuerza() < 11)
            {
                return true;
            }
            return false;
        }
        public static bool ComprobarFuerza(Griego griego)
        {
            if (griego.GetFuerza() > 0 && griego.GetFuerza() < 11)//TODO:el tope de fuerza es redundante al haber puesto en el constructor un verificador
            {
                return true;
            }
            return false;
        }

    }   
}
//Nos encontramos en algún momento entre los años 1.100 y 1.300 a.C.El rapto de Helena de Esparta por Paris de Troya ha 
//desencadenado la guerra.Para vengar la afrenta, los príncipes griegos se disponen a asaltar la ciudad de Troya.
//El objetivo de los problemas es crear los elementos que van a tomar parte en la batalla, incluyendo el famoso caballo de Troya.
//Ejercicio 1 
//En este problema se crearán las clases Troyano y Griego.
//a)  Crear la clase Troyano.Deberá contar con los siguientes atributos:
//Nombre
//edad (Valor entero positivo)
//fuerza(Valor entero positivo)
//herido
//muerto
//b)Crear los métodos que consideres necesarios para acceder a los atributos y  para darles valor.
//c)Crea el siguiente método: boolean retirarse().
//d)Crear dos métodos
//boolean comprobarEdad(int edad) : que devuelva true si la edad está entre 15 y 60 (ambos inclusive), false en caso contrario.
//boolean comprobarFuerza(int f) que devuelve true si la fuerza está entre 1 y 10 (ambos inclusive), false en caso contrario.
//e)	Crear un constructor para la clase Troyano: recibirá valores para todos los atributos, excepto herido y muerto,
//que obviamente serán falsos.Deberá comprobar que los valores dados son válidos y en caso contrario 
//poner como edad 25 y como fuerza 5.
//f)  Crea un segundo constructor sin parámetros que ponga como nombre “TroyanoX”, edad 18 y fuerza 10.
//g)	Implementar los métodos necesarios para la clase Troyano teniendo en cuenta que:
//• Los troyanos no pueden retirarse, por lo que devolverá false y mostrará lo siguiente:
//h)	 Crear la clase Griego, con los mismos atributos que la clase Troyano.
//i)	Crear un constructor para esta clase que reciba el nombre, edad y fuerza del Griego,
//j)	Crea un segundo constructor sin parámetros que ponga como nombre “GriegoX”, edad:20 y fuerza:8.
//k)	Los métodos y constructores de esta clase serán similares a los de Troyano salvo el método retirarse, ya que los 
//griegos sí lo pueden hacer, siempre que estén heridos y, evidentemente, no estén muertos.Implementar este método.

//Ejercicio 2 
//Este problema creará la clase para representar al Caballo de Troya.
//a)  Crear la clase Caballo que tendrá como atributos:
//capacidad, representa el número de guerreros griegos que puede haber dentro del caballo.No se podrá cambiar una vez le
//hemos dado valor.
//ocupacion, representa el número actual de griegos en el caballo.
//ocupantes, lista de objetos de la clase Guerrero.
//b)  Crear un constructor para la clase Caballo con espacio para tantos guerreros como indique el parámetro que se pasa
//a dicho constructor.
//c) Crear un método buscar(nombre) que busque por su nombre un guerrero dentro de la lista ocupantes y devuelva la posición 
//en que está ó -1 si no está.
//d)Crear método mostrarGuerreroPosicion(pos) Si la posición es válida, muestra en pantalla los datos del guerreo de 
//posición pos.Y sino indica que no es posible.
//e) Crear un método montarseEnCaballo(guerrero) que reciba como parámetro un guerrero, compruebe que es Griego y lo meta en el 
//array de ocupantes(si hay sitio). Si el que quiere montarse es Troyano se mostrará el siguiente mensaje y matarlo:
//Si es correcto se muestra el siguiente mensaje:
//f)  Crea el método mostarCaballo() que muestra e pantalla la información relativa:
//	-Capacidad, ocupación y lista de ocupantes con sus datos
//Ejercicio 3
//1.	Crear una clase GuerraTroya con método main() para probar las clases realizadas.
//2.	Crear un caballo con capacidad para 20 guerreros.
//3.	Crear 3  guerreros griegos(Aquiles, Agamenon y Ajax) y montarlos en el caballo.
//4.	Mostrar caballo.
//5.	Crea otro guerrero griego anónimo y móntalo en el caballo y muestra el caballo.
//6.	Buscar a Agamenon en el caballo y mostrar sus datos.
//7.	Buscar a Odiseo en el caballo y comprobar que no existe.
//8.	Crear 1 guerrero troyano (Paris ).
//9.	Montarlo en el caballo y comprobar que no es posible.

