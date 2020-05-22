using System;

namespace primeiro_POO
{
    class Personagem
    {
        public string nome = "Batman";

        public int idade = 70 ;

        public string armadura; 

        public string Atacar()
        {
            return "O personagem atacou";
        }

        static void Main(string[] args)

        
        {
            Personagem Batman = new Personagem();
            Batman.nome = " Bruce Wayne";
            Batman.idade = 70;
            Batman.armadura = "Latéx preto";

            Console.WriteLine("O nome real do Batman é"+Batman.nome);
            Console.WriteLine("A idade do Batman é:"+Batman.idade);
        }
        
        

    }
}
