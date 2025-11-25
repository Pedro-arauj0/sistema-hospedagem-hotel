using System;
using System.Collections.Generic;
using Projeto_hotel.Models;

namespace Projeto_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE HOSPEDAGEM DE HOTEL ===\n");

            var hospede1 = new Pessoa("João", "Silva");
            var hospede2 = new Pessoa("Maria", "Santos");
            var hospede3 = new Pessoa("Pedro", "Oliveira");

            Console.WriteLine("Hóspedes cadastrados:");
            Console.WriteLine($"- {hospede1.NomeCompleto}");
            Console.WriteLine($"- {hospede2.NomeCompleto}");
            Console.WriteLine($"- {hospede3.NomeCompleto}");

            var suite = new Suite("Premium", 3, 150.00m);
            Console.WriteLine($"\n{suite}");

            Console.WriteLine("\n--- TESTE 1: Reserva de 5 dias ---");
            var reserva1 = new Reserva(5);
            reserva1.CadastrarSuite(suite);
            reserva1.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2 });
            reserva1.ExibirResumo();

            Console.WriteLine("\n--- TESTE 2: Reserva de 12 dias ---");
            var reserva2 = new Reserva(12);
            reserva2.CadastrarSuite(suite);
            reserva2.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2, hospede3 });
            reserva2.ExibirResumo();

            Console.WriteLine("\n--- TESTE 3: Excedendo capacidade ---");
            var hospede4 = new Pessoa("Ana", "Costa");
            var reserva3 = new Reserva(7);
            reserva3.CadastrarSuite(suite);
            reserva3.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2, hospede3, hospede4 });

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}