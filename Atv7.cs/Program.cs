using System.Globalization;
using System;

namespace Atv7{
    class Program{
        static void Main(string[] args){

            double[] t1 = new double[3];
            double[] t2 = new double[3];

            Console.WriteLine("Triangulo 1: \n");
            double areaT1 = Math.Sqrt(Multiplicaçao(Perimetro(Medidas(t1)), t1));
            Console.WriteLine("\nTriangulo 2: \n");
            double areaT2 = Math.Sqrt(Multiplicaçao(Perimetro(Medidas(t1)), t1));
            System.Console.WriteLine($"\nArea do triangulo 1: {areaT1.ToString("F2", CultureInfo.InvariantCulture)} \nArea do triangulo 2: {areaT2.ToString("F2", CultureInfo.InvariantCulture)} \n{Area(areaT1, areaT2)}");         
        }

        static double Medidas(double[] triangulo){
            double soma = 0F;
            for (int i = 0; i < triangulo.Length; i++){
                Console.Write($"Informe a medida do lado {i+1}: ");
                    triangulo[i] = double.Parse(Console.ReadLine());
                    soma = (soma + triangulo[i]);
            }
            return soma;
        }
        static double Perimetro(double soma){
            double p = (soma/2);             //Console.Write($"PERIMETRO === {p} \n SOMA === {soma}");
            return p;
        }
        static double Multiplicaçao(double perimetro, double[] triangulo){
            double lado = 1;
            for(int i = 0; i < triangulo.Length; i++){
                lado = (lado * (perimetro - triangulo[i]));         //Console.WriteLine($"Medida de lado: {lado} ----- {lado*(perimetro - triangulo[i])}");
            }
            lado = (perimetro * lado);

            return lado;
        }
        static string Area(double area1, double area2){
            if(area1 > area2){
                return "O triangulo 1 possui uma area maior!";
            }if(area1 < area2){
                return "O triangulo 2 possui uma area maior!";
            }else{
                return "Ambos os trianuglo possuem a mesma area!";
            }
        }
    }
}