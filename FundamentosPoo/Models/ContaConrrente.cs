using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosPoo.Models
{
    public class ContaConrrente
    {
        public ContaConrrente(int numerodaConta, decimal saldoInicial)
        {
            NumeroConta = NumeroConta;
            Saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {   
            if(Saldo >= valor)
            {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que saldo disponivel");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é: " + Saldo);
        }
    }
}