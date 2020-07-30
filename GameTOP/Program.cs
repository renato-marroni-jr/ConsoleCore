using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoFoda jogo = new JogoFoda(
                                   new Jogador1("Miguel"),
                                   new Jogador2());
            jogo.IniciarJogo();
        }
    }

}
