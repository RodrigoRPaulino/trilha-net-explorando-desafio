

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

       public void CadastrarHospedes(List<Pessoa> hospedes)
       {
            Console.WriteLine("Insira as informações de cadastro");
            
            Console.WriteLine($"o nome do hospede é {hospedes}");
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count) {
                Hospedes = hospedes;
                
            } else {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade da suite é menor do que o número de hóspedes");
            }
       }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            try
            {
              // TODO: Retorna o valor da diária
               decimal valor = DiasReservados * Suite.ValorDiaria;

             // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
             if (DiasReservados >= 10) {
                valor -= Decimal.Divide(Decimal.Multiply(valor, 10), 100);
            }
            return valor;
            }
            catch

            {
              throw new Exception("Não foi possivel calcular o valor da estadia");
            }
           

            
        }
    }

    class Excecao : Exception
    {
        public Excecao(string mensagem) : base(mensagem)
        {
            
        }
    }
}
