using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02B
{
    public class Persona
    {
        //Propiedad=Campo=Atributo
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        //MÉTODOS

        //Procedimiento
        public void DevolverNombresCompletos()
        {
            Console.WriteLine(Nombres + " "+ Apellidos);
        }
        //Función
        public int MultiplicarEdad(int factor)
        { 
            return Edad*factor;
        }



    }
}
