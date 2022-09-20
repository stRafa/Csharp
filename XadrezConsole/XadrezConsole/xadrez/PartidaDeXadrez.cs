using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('a', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('b', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('c', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('d', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('e', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('f', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('g', 2).ToPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('h', 2).ToPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('a', 1).ToPosicao());
        }
    }
}
