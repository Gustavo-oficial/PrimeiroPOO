  
namespace PrimeiroPoo
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public float vida = 100.0f;

        public string Atacar(){
            return "Batman atacou";
        }
    
        public float calcularVida(float dano)
        {
            return vida - dano;
        }

        public float calcularDano(float dano)
        {
            return dano ;
        }


    }
}