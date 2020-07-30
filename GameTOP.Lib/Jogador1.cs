using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        
        public Jogador1(string nome = "Miguel")
        {
            this._Nome = nome;
        }

        //Chuta
        public string Chuta()
        {   
            return $"O {_Nome} está chutando";
        }

        //Corre      
        public string Corre()
        {   
            return $"O {_Nome} está correndo";
        }

        //Passe
        public string Passe()
        {   
            return $"O {_Nome} está passando";
        }

    }
}