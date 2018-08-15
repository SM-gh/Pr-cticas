using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Perro
    {
        //variables globales> Aquellas que no estan dentro de un metodo. Utilizan primer letra en Mayusc.
        public string Raza;
        public string Tamaño;
        public string Sexo;
        public int Peso;
        public string Color; //se pone "public" antes de la variable para poder acceder a ellas desde otra clase
        enum TiposDeComida { CROQUETAS, BASURA, AGUA } // A { Croquetas, Basura, Agua} corresponden los num.> {0,1,2}
        //Constructor> sirve para inicializar la clase
        public Perro()
        {
            Raza = "French Poodle";
            Peso = 7;
            Sexo = "Macho";
            Tamaño = "Pequeño";
            Color = "Blanco";
        }
        public Perro(string raza, int peso, string sexo, string tamaño, string color)
        {
            Raza = raza;
            Peso = peso;
            Sexo = sexo;
            Tamaño = tamaño;
            Color = color;
        }
        //Metodo
        public void Ladrar() //con el metodo "void"> no da ni recibe información 
        {

        }
        public void Correr()
        {

        }
        public bool Comer(int alimento) // con este metodo "string"se va a recibir un string
        {
            bool resultado = false;
            if (alimento == (int)TiposDeComida.AGUA)
            {
                resultado = false;
            }
            else if (alimento == (int)TiposDeComida.BASURA)
            {
                resultado = true;
            }
            else if(alimento == (int)TiposDeComida.CROQUETAS)
            {
                resultado = true;
            }
            return resultado;
        }
        public void Cagar()
        {

        }
    }
}
