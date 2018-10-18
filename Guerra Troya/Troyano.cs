using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra_Troya
{
    class Troyano
    {
        //TODO:mirar limites que pueda tener fuerza y edad y ponerselos
        //TODO:metodo para enseñar todos los atributos
        private string nombre;
        private int edad, fuerza;
        private bool herido, muerto,retirarse;
        public Troyano()
        {
            this.nombre = "TroyanoX";
            this.edad = 18;
            this.fuerza = 10;
        }
        public Troyano(string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;
            if (edad >= 0 && edad <= 120)
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }
            if (fuerza >= 0 && fuerza <= 10)
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.fuerza = 5;
            }
        }
        public void ShowAll()
        {
            Console.WriteLine("Facción:Troyanos\nGuerrero: " + nombre + "\nEdad: " + edad + "\nFuerza: " + fuerza);
            if (herido)
            {
                Console.WriteLine("El combatiente esta herido");
            }
            if (muerto)
            {
                Console.WriteLine("El combatiente ha muerto");
            }
            if (retirarse)
            {
                Console.WriteLine("El combatiente se ha retirado");
            }
            else
            {
                Console.WriteLine("Estado: Combatiente sano y en activo");
            }
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }
        public void SetHerido(bool herido)
        {
            this.herido = herido;
        }
        public void SetMuerto(bool muerto)
        {
            this.muerto=muerto;//TODO:En realidad no haria falta introducir un booleano, solo hacer que cuando se invoque el metodo el estado cambie a muerto
        }
        public void SetRetirarse(bool retirarse)
        {
            if (retirarse == true)
            {
                Console.WriteLine("Los Guerreros Troyanos NUNCA se retiran!!!");
            }//No hace falta ponerle valor porque siempre estara en false
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public bool GetHerido()
        {
            return herido;
        }
        public bool GetMuerto()
        {
            return muerto;
        }
        public bool GetRetirarse()
        {
            return retirarse;
        }
    }
}
//e)	Crear un constructor para la clase Troyano: recibirá valores para todos los atributos, excepto herido y muerto,
//que obviamente serán falsos.Deberá comprobar que los valores dados son válidos y en caso contrario 
//poner como edad 25 y como fuerza 5.
