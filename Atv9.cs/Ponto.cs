namespace Atv9 {
    class Ponto {
        
        private int X;
        private int Y;

        public Ponto() {}
        public Ponto(int valorX) {
            X = valorX;
        }
        public Ponto(int vX, int vY) {
            X = vX;
            Y = vY;
        }

        public void CoordenadaX(int pointX) {
            X = ++pointX;
        }
        public void CoordenadaXY(int pX, int pY){
            X = ++pX;
            Y = ++pY;
        }
        public void ExibirPontos() {
            Console.WriteLine($"Pontos: ({X},{Y})");
        }

    }
}