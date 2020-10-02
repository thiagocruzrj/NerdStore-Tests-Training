﻿using System;

namespace NerdStore.Vendas.Domain
{
    public class Voucher
    {
        public Voucher(string codigo, decimal? percentualDesconto, decimal? valorDesconto, TipoDescontoVoucher tipoDescontoVoucher, int quantidade, DateTime dataValidade, bool ativo, bool utilizado)
        {
            Codigo = codigo;
            PercentualDesconto = percentualDesconto;
            ValorDesconto = valorDesconto;
            TipoDescontoVoucher = tipoDescontoVoucher;
            Quantidade = quantidade;
            DataValidade = dataValidade;
            Ativo = ativo;
            Utilizado = utilizado;
        }

        public string Codigo { get; private set; }
        public decimal? PercentualDesconto { get; private set; }
        public decimal? ValorDesconto { get; private set; }
        public TipoDescontoVoucher TipoDescontoVoucher { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime DataValidade { get; private set; }
        public bool Ativo { get; private set; }
        public bool Utilizado { get; private set; }

        public bool ValidarSeAplicavel()
        {
            return true;
        }
    }

    public enum TipoDescontoVoucher
    {
        Porcentagem = 0,
        Valor = 1
    }
}