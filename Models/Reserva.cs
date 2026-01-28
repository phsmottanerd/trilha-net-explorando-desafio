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
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suite é menor que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
{
    return Hospedes.Count * DiasReservados;
}

        }

        public decimal CalcularValorDiaria()
{
    decimal valor = DiasReservados * Suite.ValorDiaria;

    if (DiasReservados >= 10)
    {
        decimal desconto = valor * 0.10M;
        valor = valor - desconto;
    }

    return valor;
}

    }
}