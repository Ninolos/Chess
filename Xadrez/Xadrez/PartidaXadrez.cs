using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez.Xadrez
{
    class PartidaXadrez
    {
        public tabuleiro tab { get; private set; } 
        private int turno;
        private Cor jogadorAtual;

        public PartidaXadrez()
        {
            tab = new tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {

        }
    }
}
