using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Turismo : Moto
    {
        private static string Color = "Rojo";
        private static int Cilindraje = 500;
        private static int VelocidadMaxima = 290;

        public Turismo (string nombreTurismo):base(nombreTurismo) 
        {}
        public static int CilindrajeT
        {
            get { return  Cilindraje;}
            set { Cilindraje = value; }
        }

        public static string ColorT
        {
            get {return Color;}
            set { Color = value; }
        }

        public static int VelociadadMaximaT
        {
            get { return VelocidadMaxima; }
            set { VelocidadMaxima = value; }
        }
    }
}