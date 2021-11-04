using System;
using System.Globalization;
using Avaliação.Entidades;
using Avaliação.Servicos;

namespace Avaliação
{
    class Program
    {
        static void Main(string[] args)
        {
            //11 linhas de código para o usuário entrar com os dados
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("modelo: ");
            string model = Console.ReadLine();

            Console.Write("Check -in (dd / MM / yyyy HH: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Check -out (dd / MM / yyyy HH: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciando os dados que o usuário digitou, a data de inicio e a final do alguel, juntamente com o modelo do carro
            AluguelCarro aluguelCarro = new AluguelCarro(start, finish, new Veiculo(model));

            //instanciando os dados que o usuário digitou, a quantidade de dias e horas que o usuário alugou o carro
            ServicoLocacao servicoDeAluguel = new ServicoLocacao(hour, day, new TaxaServicoBR());

            //chamando o método ProcessInvoice
            servicoDeAluguel.ProcessoFatura(aluguelCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro._fatura);
        }
    }
}
