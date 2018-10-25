namespace tabuleiro {
    class Posicao {

        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            linha = this.linha;
            coluna = this.coluna;
        }

        public override string ToString() {
            return linha + ", " + coluna;
        }
    }
}
