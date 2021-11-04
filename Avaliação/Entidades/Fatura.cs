using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Avaliação.Entidades
{
    class Fatura
    {
        //criando as propriedades
        public double Pagamento { get; private set; }
        public double Taxa { get; private set; }

        //criando construtor vazio
        public Fatura()
        {
        }

        //criando contrutor personalizado
        public Fatura(double pagamento, double taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }

        //método para o pagamento total
        public double PagamentoTotal
        {
            get { return Pagamento + Taxa; }
        }

        //conversão para string
        public override string ToString()
        {
            return "Pagamento: "
            + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento Total: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
