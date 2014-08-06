using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Orientacao_a_Objetos
{
    class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        public Agencia agencia;

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public Conta()
        {

        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void ImprimiExtrato()
        {
            Console.WriteLine("Saldo: " + this.saldo);
        }

        public double ConsultaSalarioDisponivel()
        {
            return this.saldo + this.limite;
        }

        public void Transfere(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }
    }
}
