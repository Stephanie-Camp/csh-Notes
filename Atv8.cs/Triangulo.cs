namespace Atv8 {
    class Triangulo {

        float[] Lados = new float[3];

        public float Area() { 

            float razaoP = P();
            float raizElementos = 1;

                for (int lado = 0; lado < 3; lado++) {
                    raizElementos = raizElementos * (razaoP - Lados[lado]); //parte interna da raiz 
                }
                raizElementos = (float)Math.Sqrt(razaoP * raizElementos);

            return raizElementos; //return do resultado da raiz
        }

        public float P() { //razao 'P'
            float soma = 0;

            for (int lado = 0; lado < 3; lado++) {

                Console.Write($"Informe a medida do lado {lado+1}: ");
                Lados[lado] = float.Parse(Console.ReadLine()); //medida dos lados obtido

                soma = (soma + Lados[lado]); //perimetro obtido
            }

            return (soma/2); //return p
        } 

  }
}