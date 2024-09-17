namespace ProjetoIntegrador.Models
{
    public class Crianca
    {
        //DADOS PESSOAIS DA CRIANÇA
        public int Id { get; set; }
        public string NomeCri { get; set; } = string.Empty;
        public string DataNascCri { get; set; } = string.Empty;
        public string PossuiDeficiencia { get; set; } = string.Empty;
        public string Deficiencia { get; set; } = string.Empty;
        public string ResponsaveisCpf { get; set; } = string.Empty;


        //DOCUMENTAÇÃO NECESSÁRIA DA CRIANÇA
        public string RGCri { get; set; } = string.Empty;
        public string CPFCri { get; set; } = string.Empty;
        public string Escola {  get; set; } = string.Empty;
        public string Sala { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;
        public string Periodo { get; set; } = string.Empty;
    }
}
