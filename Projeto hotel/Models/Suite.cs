using System;

namespace Projeto_hotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public override string ToString()
        {
            return $"Suíte {TipoSuite} - Capacidade: {Capacidade} pessoas - R$ {ValorDiaria:F2}/diária";
        }
    }
}