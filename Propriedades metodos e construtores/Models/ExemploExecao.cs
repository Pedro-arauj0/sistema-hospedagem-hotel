using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_construtores.Models
{
    public class ExemploExecao
    {
        public void Metodo1()
        {
            try
            {
            Metodo2();
        }catch (Exception ex)
        {
            Console.WriteLine("Exeção tratada." + ex.StackTrace);
        }
    }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exeção");
        }
    }
}
