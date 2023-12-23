using System.Globalization;
using System;
namespace Atv3 {
    class Program{
        static void Main(string[] args){
            string nome = "Ana";
            int idade = 18;
            float peso = 64.5F;
            char sexo = 'F';
            System.Console.WriteLine("Nome:  " + nome + "\nIdade: " + idade + "\nPeso:  " + peso.ToString("F1", CultureInfo.InvariantCulture) + "\nSexo:  " + sexo);
        }
    } 
}