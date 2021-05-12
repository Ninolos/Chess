using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    class tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca (Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.Linha <0 || pos.Linha>=linhas || pos.Coluna<0 || pos.Coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida");
            }
        }
    }
}
