using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public tabuleiro tab { get; protected set; }

        public Peca(tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public Peca()
        {

        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] movimentosPossiveis();       
       
    }
}
