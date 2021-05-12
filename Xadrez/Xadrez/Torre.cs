using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;
using Tabuleiro;

namespace Xadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
