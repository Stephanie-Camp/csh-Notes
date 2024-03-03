namespace Atv9 {
    class Program {
        static void Main(string[] args) {

            Ponto novoPonto2 = new Ponto();
            novoPonto2.CoordenadaX(15);
            Ponto novoPonto3 = new Ponto();
            novoPonto3.CoordenadaXY(5, 9);

            novoPonto2.ExibirPontos();
            novoPonto3.ExibirPontos();
        }
    }
}