﻿namespace Atv9 {
    class Program {
        static void Main(string[] args) {

            Ponto novoPonto = new Ponto();

            Ponto novoPonto2 = new Ponto();
            novoPonto2.CoordenadaX(5);
            Ponto novoPonto3 = new Ponto();
            novoPonto3.CoordenadaXY(5, 9);

            novoPonto2.ExibirPontos();
            novoPonto3.ExibirPontos();
        }
    }
}