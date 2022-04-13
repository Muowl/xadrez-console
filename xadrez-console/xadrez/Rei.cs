using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;// Cor do rei this.cor

        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0,0);

            // Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Suldeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // Noroeste
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) // Verificando se posição é válida e se o espaço esta ocupado por alguma peça ou peça inimiga (cor diferente do rei)
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }

    }
}
