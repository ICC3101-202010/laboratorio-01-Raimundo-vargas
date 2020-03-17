using System;

namespace Laboratorio_1
{
    class Program
    {
        static void Main()
            {

                Person persona = new Person("Bob", "kunga");
                //Jugador 1
                int jugada = 0;
                jugada = persona.Lanzar();
                Console.WriteLine(jugada);



            }
    }
    
   
    class Person
    {
        private string last;
        private string first;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }
        //metodos funciones
        public int Lanzar()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 3);
            return a;

        }

        // Remaining implementation of Person class.
    }
}
