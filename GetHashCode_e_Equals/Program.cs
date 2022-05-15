using System;
using GetHashCode_e_Equals.Entities;

namespace GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("Maria", "maria@hotmail.com");
            Client client2 = new Client("Joao", "Joao@hotmail.com");
            Client client5 = new Client("Alex", "Alex@hotmail.com");
            Client client6 = new Client("Alex", "Alex@hotmail.com");

            //** Equals
            //----------------------------------------Ex 001 - False
            Console.WriteLine(client.Equals(client2));
            //----------------------------------------Ex 002 - True
            Console.WriteLine(client5.Equals(client6));

            //** GetHashCode
            //----------------------------------------Ex 003 - HashCode diferentes
            Console.WriteLine(client.GetHashCode());
            Console.WriteLine(client2.GetHashCode());
            //----------------------------------------Ex 004 - HashCode Iguais
            Console.WriteLine(client5.GetHashCode());
            Console.WriteLine(client6.GetHashCode());

            //** Igualdade
            //----------------------------------------Ex 005
            //Compara a referencia do ponteiro de memoria do objeto, obs:Objetos diferentes
            Client client98 = new Client("Maria", "maria@hotmail.com");
            Client client99 = new Client("Maria", "maria@hotmail.com");
            Console.WriteLine(client99 == client98); 
            string a = Console.ReadLine();
        }
    }
}
