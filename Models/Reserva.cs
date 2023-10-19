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
        if (hospedes.Count <= Suite.Capacidade)
    {
        Hospedes = hospedes;
    }
    else
    {
        throw new Exception("A capacidade da suíte é insuficiente para acomodar todos os hóspedes.");
    }
try
{
    if (hospedes.Count < 2)
    {
        throw new Exception("O número de hóspedes não pode exceder 2 pessoas.");
    }
}

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Environment.Exit(1);
    }
}

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.90m;
            }

            return valor;
        }
    }
}