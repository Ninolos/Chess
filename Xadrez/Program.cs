using System;
using Tabuleiro;
using Xadrez.Tabuleiro;
using Xadrez.Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            tabuleiro tab = new tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta) , new Posicao(0, 0));
            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
