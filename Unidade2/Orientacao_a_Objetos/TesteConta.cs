﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class TesteConta
    {
        private static void Main8()
        {
            Conta conta = new Conta();

            conta.Deposita(2000);
            conta.ImprimiExtrato();

            conta.Saca(1000);
            conta.ImprimiExtrato();

            double saldoDisponivel = conta.ConsultaSalarioDisponivel();
            Console.WriteLine("Saldo dísponivel: " + saldoDisponivel);
            Console.ReadKey();  
        }
    }
}
