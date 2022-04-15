namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
        public Peca peca(int linha, int coluna) // Método para retornar uma peça em dada linha e coluna para usar na tela
        {
            return pecas[linha,coluna];
        }
        public Peca peca(Posicao pos) // Método para retornar uma peça dada sua posição (sobrecarga do método anterior)
        {
            return pecas[pos.linha,pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos)!= null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos) && peca(pos).cor == p.cor)
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!"); // Dessa forma testamos se a posição é válida e se já existe uma peça nessa posição
            }
            pecas[pos.linha,pos.coluna] = p; //Controle do objeto (no programa principal nos testes chamado de 'tab') para acossiar uma peça a uma posição
            p.posicao = pos; //Atualiza a posição que a peça p está (começa com o valor null) para a própria peça
        }
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha,pos.coluna] = null; // Marca a posição onde ela estava no tabuleiro como nula
            return aux;
        }
        public bool posicaoValida(Posicao pos) // Verifica se dada posição é válida
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
