namespace Avaliação.Servicos
{
    class TaxaServicoBR : ITaxaServico
    {
        //criando um método de taxa BR pela interface
        public double Taxa(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
