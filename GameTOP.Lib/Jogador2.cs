using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "João Pedro está chutando";
        }

        public string Corre()
        {
            return "João Pedro está correndo";
        }

        public string Passe()
        {
            return "João Pedro está passando";
        }
    }
}