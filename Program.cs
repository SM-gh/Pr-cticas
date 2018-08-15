using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    public enum TiposDeComida { CROQUETAS, BASURA, AGUA } // A { Croquetas, Basura, Agua} corresponden los num.> {0,1,2}

    class Program
    {
        static void Main(string[] args)
        {
            bool alimentado = false;
            Perro Perro1 = new Perro(); //"Perro1" es el nombre del objeto de la clase "Perro"

            Perro1.Raza = "French Poodle";
            Perro1.Peso = 7;
            Perro1.Sexo = "Macho";
            Perro1.Tamaño = "Pequeño";
            Perro1.Color = "Blanco";

            alimentado = Perro1.Comer((int)TiposDeComida.BASURA);
            if (alimentado)
            {
                Console.WriteLine("El perro " + Perro1.Raza + " comió " + Convert.ToString(TiposDeComida.AGUA));
            }
            else
            {
                Console.WriteLine("El perro ha sido alimentado");
            }
            Console.Read();

            Perro Perro2 = new Perro();
            Console.WriteLine("El perro " + Perro2.Raza + " comió " + Convert.ToString(TiposDeComida.AGUA));
            Console.Read();

            Perro Perro3 = new Perro("Shitzu",15,"Hembra","Pequeño","Gris");
            Console.WriteLine("El perro " + Perro3.Raza + " comió " + Convert.ToString(TiposDeComida.AGUA));
            Console.Read();

        }
    }
}
