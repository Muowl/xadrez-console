using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;// Cor do rei this.cor

        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao (0,0);

            // Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true; // Enquanto a posição for válida e podermos mover a peça, adicionamos o valor true aquela matriz de bool
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break; // Forca a parada do while se encontra uma peça inimiga, para que uma peça não consiga pular uma peça e capturar a anterior
                }
                pos.linha = pos.linha - 1;
            }
            // Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break; // Forca a parada do while se encontra uma peça inimiga
                }
                pos.linha = pos.linha + 1;
            }
            // Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break; // Forca a parada do while se encontra uma peça inimiga
                }
                pos.coluna = pos.coluna + 1;
            }
            // Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break; // Forca a parada do while se encontra uma peça inimiga
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }

    }
}
