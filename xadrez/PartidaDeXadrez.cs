using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
            
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).ToPosicao());
        }
    }
}
