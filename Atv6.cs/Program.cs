using System.Globalization;
using System;
namespace Atv6{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("(use space to separate the informations) \nEntry NAME, AGE, GENDER, HEIGHT, CIVIL STATUS and DEATH CERTIFICATE:");
            string cadastro = System.Console.ReadLine();
            string[] dados = cadastro.Split(" ");
            
            string nome = dados[0];
            int idade = int.Parse(dados[1]); 
            char sexo = char.Parse(dados[2]); 
            float altura = float.Parse(dados[3], CultureInfo.InvariantCulture); 
            string estCivil = dados[4]; 
            bool ati = bool.Parse(dados[5]);
            
            System.Console.WriteLine($"\nREGISTER:: \n  Name: {nome} \n  Age: {idade} \n  Gender: {sexo} \n  Height: {altura.ToString("F2", CultureInfo.InvariantCulture)} \n  Civil Status: {estCivil} \n  Death Certificate: {ati}");
        }
    }
}