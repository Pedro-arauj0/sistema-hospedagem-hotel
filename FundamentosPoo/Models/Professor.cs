using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPoo.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public  override void Apresentar()
        {
            Console.WriteLine($"Óla, meu nome é {Nome}, teho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}