using System;
using System.Collections.Generic;
namespace Aplicacao_Transferencia_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Eliezer Cunha");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
