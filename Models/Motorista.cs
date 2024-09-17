namespace ProjetoIntegrador.Models
{
    public class Motorista
    {
        //DADOSPESSOAIS

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string DataNasc { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        //ENDEREÇO
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;


        // INFORMAÇOES DO VEICULO
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string AnoFab { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string CapacidadePassageiros { get; set; } = string.Empty;


        //DOCUMENTAÇÃO NECESSÁRIA
        public string CNH { get; set; } = string.Empty;
        public string DataValidadeCNH { get; set; } = string.Empty;
        public string CRLV { get; set; } = string.Empty; // CERTIFICADO DE REGISTRO E LICENCIAMENTO DE VEÍCULO
        public string CRMC { get; set; } = string.Empty; // CERTIFICADO DE CURSO DE TRANSPORTE ESCOLAR
        public string DataValidadeCRMC { get; set; } = string.Empty;//   DATA DE VALIDADE DO CERTIFICADO DE CURSO DE TRANSPORTE ESCOLAR

    }
}
