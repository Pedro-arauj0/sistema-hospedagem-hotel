using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public bool CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                Console.WriteLine("Erro: É necessário cadastrar uma suíte antes de adicionar hóspedes.");
                return false;
            }

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                return true;
            }
            else
            {
                Console.WriteLine($"Erro: A suíte comporta apenas {Suite.Capacidade} pessoas, mas foram informados {hospedes.Count} hóspedes.");
                return false;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                Console.WriteLine("Erro: Nenhuma suíte cadastrada.");
                return 0;
            }

            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                decimal desconto = valorTotal * 0.10m;
                valorTotal -= desconto;
                Console.WriteLine($"Desconto de 10% aplicado: -R$ {desconto:F2}");
            }

            return valorTotal;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n==== RESUMO DA RESERVA ====");
            
            if (Suite != null)
            {
                Console.WriteLine($"Suíte: {Suite.TipoSuite}");
                Console.WriteLine($"Capacidade: {Suite.Capacidade} pessoas");
                Console.WriteLine($"Valor da diária: R$ {Suite.ValorDiaria:F2}");
            }
            
            Console.WriteLine($"\nDias reservados: {DiasReservados}");
            Console.WriteLine($"Quantidade de hóspedes: {ObterQuantidadeHospedes()}");
            
            if (Hospedes.Any())
            {
                Console.WriteLine("\nHóspedes:");
                foreach (var hospede in Hospedes)
                {
                    Console.WriteLine($"  - {hospede.NomeCompleto}");
                }
            }
            
            Console.WriteLine($"\nValor total: R$ {CalcularValorDiaria():F2}");
            Console.WriteLine("===========================\n");
        }
    }
}