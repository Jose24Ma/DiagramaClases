using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Enduro : Moto
    {
        private static string ColorE = "Azul";
        private static int CilindrajeE = 800;
        private static int VelocidadMaximaE = 250;

        public Enduro(string nombreEnduro) : base(nombreEnduro) 
        {
        }
        public static int Cilindraje
        {
            get { return CilindrajeE; }
            set { CilindrajeE = value; }
        }

        public static string Color
        {
            get { return ColorE; }
            set { ColorE = value; }
        }

        public static int Velocidad
        {
            get { return VelocidadMaximaE; }
            set { VelocidadMaximaE = value; }

        }
    }
}