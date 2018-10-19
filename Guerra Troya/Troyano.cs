using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra_Troya
{
    class Troyano
    {
        
        private string nombre;
        private int edad, fuerza;
        private bool herido, muerto;
        public Troyano()
        {
            this.nombre = "TroyanoX";
            this.edad = 18;
            this.fuerza = 10;
        }
        public Troyano(string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;
            if (ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }
            if (ComprobarFuerza(fuerza))
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.fuerza = 5;
            }
        }
        public bool ComprobarEdad(int edad)
        {
            if (edad >= 15 && edad <= 60)
            {
                return true;
            }
            return false;
        }
        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza >= 0 && fuerza <= 10)
            {
                return true;
            }
            return false;
        }
        public void ShowAll()
        {
            Console.WriteLine("Facción:Troyanos\nGuerrero: " + nombre + "\nEdad: " + edad + "\nFuerza: " + fuerza);
            if (herido&&!muerto)
            {
                Console.WriteLine("El combatiente esta herido");
            }
            else if (muerto)
            {
                Console.WriteLine("El combatiente ha muerto");
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
            if (ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }
        }
        public void SetFuerza(int fuerza)
        {
            if (ComprobarFuerza(fuerza))
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.fuerza = 5;
            }
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
                Console.WriteLine("Los Guerreros Troyanos NUNCA se retiran!!!");
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
    }
}
//e)	Crear un constructor para la clase Troyano: recibirá valores para todos los atributos, excepto herido y muerto,
//que obviamente serán falsos.Deberá comprobar que los valores dados son válidos y en caso contrario 
//poner como edad 25 y como fuerza 5.
