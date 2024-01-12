using System.Globalization;
using System;

namespace Atv7{
    class Program{
        static void Main(string[] args){

            //criaçao do vetor de medidas dos triangulos
            double[] t1 = new double[3];
            double[] t2 = new double[3];

            Console.WriteLine("Triangulo 1: \n");
            double areaT1 = (raiz(P(t1), t1));  //calculo da raiz
            Console.WriteLine("\nTriangulo 2: \n");
            double areaT2 = (raiz(P(t2), t2));  //calculo da raiz

            System.Console.WriteLine($"\nArea do triangulo 1: {areaT1.ToString("F2", CultureInfo.InvariantCulture)}" + 
            $"\nArea do triangulo 2: {areaT2.ToString("F2", CultureInfo.InvariantCulture)} \n{Area(areaT1, areaT2)}");         
        }

        static double P(double[] triangulo){ //captura das medidas e calculo do p
            double soma = 0;
            for (int i = 0; i < triangulo.Length; i++){
                Console.Write($"Informe a medida do lado {i+1}: ");
                    triangulo[i] = double.Parse(Console.ReadLine());
                    soma = (soma + triangulo[i]);
            }
            return (soma/2);
        }
        static double raiz(double perimetro, double[] triangulo){ //parte interna da raiz
            double lado = 1;
            for(int i = 0; i < triangulo.Length; i++){ lado = (lado * (perimetro - triangulo[i])); }       //Console.WriteLine($"Medida de lado: {lado} ----- {lado*(perimetro - triangulo[i])}");
            lado = (perimetro * lado);

            return Math.Sqrt(lado);
        }
        static string Area(double area1, double area2){ //resultado da comparaçao entre os dois triangulos
            if(area1 > area2){
                return "O triangulo 1 possui uma area maior!";
            }else if(area1 < area2){
                return "O triangulo 2 possui uma area maior!";
            }else{
                return "Ambos os trianuglo possuem a mesma area!";
            }
        }
    }
}