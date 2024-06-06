namespace SisecomClient.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public double Codigo { get; set; }
        public Boolean PfPj { get; set; }
        public double CpfCnpj { get; set; }
        public double RgIe { get; set; }
        public string NomeOuRazaoSocial { get; set; }
        public string NomeAbreviadoOuNomeFantasia { get; set; }

    }
}
