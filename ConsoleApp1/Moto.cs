using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Turismo turismo = new Turismo("Yamaha Tracer");
            Enduro enduro = new Enduro("Honda");
            Chopper chopper = new Chopper("Bajah Discover");

            enduro.ImprimirEnduro();
            turismo.ImprimirTurismo();
            chopper.ImprimirChopper();
            
        }
    }
    public class Moto 
    {
       
        public Moto (string nombre)
        {
            TipoMoto = nombre;
        }
        private string TipoMoto;

        public string TipoMot
        {
            get => TipoMoto;
            set{ TipoMoto = value; }
        }

        public void arrancar()
        {
            Console.WriteLine("La moto arranco");
        }

        public void acelerar()
        {
            Console.WriteLine("La moto hizo una aceleracion");
        }

        public void frenar()
        {
            Console.WriteLine("La moto freno");
        }

        public void apagar()
        {
            Console.WriteLine("La moto se apago");
        }
        public void ImprimirEnduro() 
        {
            Console.WriteLine("El tipo de moto es:"+ TipoMoto);
            Console.WriteLine("Tiene un tipo de cilindraje :" + Enduro.Cilindraje +" CC");
            Console.WriteLine("De color:" + Enduro.Color);
            Console.WriteLine("Con una velociada maxima de:" + Enduro.Velocidad + " Km\n");
        }

        public void ImprimirChopper()
        {
            Console.WriteLine("El tipo de moto es:" + TipoMoto);
            Console.WriteLine("Tiene un tipo de cilindraje :" + Chopper.Cilindraje + " CC");
            Console.WriteLine("De color:" + Chopper.Color);
            Console.WriteLine("Con una velociada maxima de:" + Chopper.VelocidadMaxima + " Km\n");

        }

        public void ImprimirTurismo()
        {
            Console.WriteLine("El tipo de moto es:" + TipoMoto);
            Console.WriteLine("Tiene un tipo de cilindraje :" + Turismo.CilindrajeT + " CC");
            Console.WriteLine("De color:" + Turismo.ColorT);
            Console.WriteLine("Con una velociada maxima de:" + Turismo.VelociadadMaximaT + " Km\n");

        }
    }
}