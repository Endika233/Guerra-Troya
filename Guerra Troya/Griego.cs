using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra_Troya
{
    class Griego
    {
        private string nombre;
        private int edad, fuerza;
        private bool herido, muerto,retirarse;//TODO:Crear atributo string estado=esta herido, muerto o herido y retirandose
        public Griego()
        {
            this.nombre = "GriegoX";
            this.edad = 20;
            this.fuerza = 8;
        }
        public Griego(string nombre, int edad, int fuerza)
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
            Console.WriteLine("Facción:Griegos\nGuerrero: "+nombre+"\nEdad: "+edad+"\nFuerza: "+fuerza);
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
            this.muerto = muerto;
        }
        public void SetRetirarse(bool retirarse)
        {
            if (herido && !muerto)
            {
                this.retirarse = retirarse;
            }
            else
            {
                Console.WriteLine("El guerrero debe estar herido y vivo para poder retirarse");
            }
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
