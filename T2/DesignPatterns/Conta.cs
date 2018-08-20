﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }
        public int Valor { get; internal set; }
        public object DataAbertura { get; internal set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }

    enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
}
