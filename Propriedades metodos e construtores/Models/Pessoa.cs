using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_construtores.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
public Pessoa(string nome,string sobrenome)
{
            Nome = nome;
            Sobrenome = sobrenome;
}


public void Deconstruct(out string nome, out string sobrenome)
{
    nome = Nome;
    sobrenome = Sobrenome;
}

        private string _nome;
        private int _Idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
         public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade
        {
            get => _Idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _Idade = value;
            }
         }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        } 
    }
}