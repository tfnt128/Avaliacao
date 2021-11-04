namespace Avaliação.Entidades
{
    class Veiculo
    {
        //criando a propriedade
        public string Modelo { get; set; }

        //criando construtor vazio
        public Veiculo()
        {
        }

        //criando construtor personalizado
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }

    }
}
