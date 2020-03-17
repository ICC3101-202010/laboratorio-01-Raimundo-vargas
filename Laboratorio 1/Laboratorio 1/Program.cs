using System;

namespace Laboratorio_1
{
    class Pers
    {
        static void Main(String[] args)
            {
                Persona Pers = new Persona();
                Pers.Apellido = "Vargas";
                Console.WriteLine("Apellido: {0}",Pers.Apellido);

            }
    }
    
    class Persona
    {
        //atributos datos
        public string Nombre;
        public string Apellido;
        //metodos funciones
        public void lanzar()
        {

        }


    }
    

}
