using System;
using Avaliação.Entidades;

namespace Avaliação.Servicos
{
    class ServicoLocacao
    {
        //criando as propriedades
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }
        private ITaxaServico TaxaServico;

        //criando construtor vazio
        public ServicoLocacao()
        {
        }

        //criando construtor personalizado
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            TaxaServico = taxaServico;
        }
        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Checkout.Subtract(aluguelCarro.Checkin);
            double pagamento = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
               pagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            double taxa = TaxaServico.Taxa(pagamento);
            aluguelCarro._fatura = new Fatura(pagamento, taxa);
        }
    }
}
