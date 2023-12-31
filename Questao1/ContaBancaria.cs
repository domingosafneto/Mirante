﻿using System.Globalization;

namespace Questao1
{
    class ContaBancaria {
        public int Numero { get; }

        public string Titular { get; set; }

        public double DepositoInicial { get; set; }

        private double Saldo { get; set; }


        public ContaBancaria(int pNumero, string pTitular, double pDepositoInicial) {
            Numero = pNumero;
            Titular = pTitular;
            DepositoInicial = pDepositoInicial;

            Deposito(pDepositoInicial);
        }

        public ContaBancaria(int pNumero, string pTitular) {
            Numero = pNumero;
            Titular = pTitular;
            Saldo = 0;
        }

        public void Deposito(double pQuantia) {
            Saldo = pQuantia + Saldo;
        }

        public void Saque(double pQuantia) {
            Saldo = (Saldo - pQuantia) - 3.5;
        }

        public double GetSaldo() { 
            return Saldo; 
        }


    }
}
