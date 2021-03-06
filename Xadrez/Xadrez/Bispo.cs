using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez.Xadrez
{
    class Bispo : Peca
    {
        public Bispo(tabuleiro tab, Cor cor) :base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "B";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }        
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //noroeste
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirvalores(pos.Linha - 1, pos.Coluna - 1);
            }
            //nordeste
            pos.definirvalores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirvalores(pos.Linha - 1, pos.Coluna + 1);
            }

            //sudeste
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirvalores(pos.Linha + 1, pos.Coluna + 1);
            }

            //sudoeste
            pos.definirvalores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirvalores(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;
        }
    }
}
