using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class cassiana
    {
        public string Nome { get; set; }
        public List<string> Habilidades { get; set; }
        public int Idade { get; set; }
        public cassiana(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Habilidades = new List<string> { "assitir filme", "Trabalhar", "Estudar" };
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine("Habilidades: " + string.Join(", ", Habilidades));
        }
    }
}
