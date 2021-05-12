using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;
using Tabuleiro;

namespace Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei(tabuleiro tab, Cor cor) :base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
