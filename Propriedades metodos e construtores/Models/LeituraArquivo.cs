using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_construtores.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] Linhas, int QuantidadedeLinhas) Lerarquivo(string Caminho)
        {   
        try
        {
            string[] linhas = File.ReadAllLines(Caminho);
            return(true, linhas, linhas.Count());
        }catch(Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}