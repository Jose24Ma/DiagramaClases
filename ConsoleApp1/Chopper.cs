using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Chopper : Moto
    {
        private static string ColorC = "Verde";
        private static int CilindrajeC = 600;
        private static int VelocidadMaximaC = 290;

        public Chopper(string nombreChopper) : base(nombreChopper)
        {}
        public static int Cilindraje
        {
            get { return CilindrajeC; }
            set { CilindrajeC = value; }    
        }

        public static string Color
        {
            get { return ColorC; }
            set { ColorC = value; }
        }

        public static int VelocidadMaxima
        {
            get { return VelocidadMaximaC; }
            set { VelocidadMaximaC = value; }
        }
    }
}