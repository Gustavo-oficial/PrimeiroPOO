  
using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem batman = new Personagem();
            batman.nome = "Bruce Wayne";
            batman.idade = 81;

            Console.WriteLine(batman.Atacar());

            Console.WriteLine("-----------------------");
            
            Console.WriteLine("A vida restante é:" +batman.calcularVida(10f) );

            Console.WriteLine("-----------------------");

            Console.WriteLine("O dano foi de:" +batman.calcularDano(10f));


        }
    }
}