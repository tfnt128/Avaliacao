using System;

namespace Avaliação.Entidades
{
    class AluguelCarro
    {
        //criando as propriedades
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Veiculo _veiculo { get; private set; }
        public Fatura _fatura { get; set; }

        //criando construtor vazio
        public AluguelCarro()
        {
        }

        //criando construtor personalizado
        public AluguelCarro(DateTime checkin, DateTime checkout, Veiculo veiculo)
        {
            Checkin = checkin;
            Checkout = checkout;
            _veiculo = veiculo;
            _fatura = null;
        }
    }
}
