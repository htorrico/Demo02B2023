using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba;

namespace Demo02B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Console.WriteLine("Hola mundo");

            //Declarar variables
            int Edad = 0;
            string Nombre = "Hugo";

            //Declarar Objetos
            //Primera Forma
            Persona persona = new Persona();
            persona.Nombres = "Hugo";
            persona.Apellidos = "Torrico";
            persona.Edad = 34;

            //Segunda Forma
            Persona persona1 = new Persona
            {
                Nombres = "Reyna",
                Apellidos = "Marquez",
                Edad = 6

            };


            //persona.DevolverNombresCompletos();

            //int doble=persona.MultiplicarEdad(5);
            //Console.WriteLine(doble);

            Triangulo triangulo = new Triangulo
            {
                LadoA = 7,
                LadoB = 24,
                LadoC = 25
            };

            double area= triangulo.CalcularArea();
            
            Console.WriteLine(area);

            Console.Read();
        }

    }

   
}
