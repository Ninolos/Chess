using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
        }

        public Peca()
        {

        }
    }
}
