namespace ProjetoIntegrador.Models
{
    public class Responsavel
    {
        //DADOSPESSOAIS

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string GrauParentesco { get; set; } = string.Empty;
        public string DataNasc { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ContatoEmergencia { get; set; } = string.Empty;
        public string NomeContatoEmergencia { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        //DOCUMENTAÇÃO NECESSÁRIA DO RESPONSÁVEL
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        //ENDEREÇO
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;  
        public string CEP { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;

       //---------------------------------------------------------------
        
        //DADOSPESSOAIS DO RESPONSÁVEL ADC
        public string NomeAdc { get; set; } = string.Empty;
        public string GrauParentescoAdc { get; set; } = string.Empty;
        public string TelefoneAdc { get; set; } = string.Empty;


        //ENDEREÇO
        public string CEPAdc { get; set; } = string.Empty;
        public string RuaAdc { get; set; } = string.Empty;
        public string NumeroAdc { get; set; } = string.Empty;
        public string BairroAdc { get; set; } = string.Empty;
        public string CidadeAdc { get; set; } = string.Empty;
        public string EstadoAdc { get; set; } = string.Empty;
        public string ComplementoAdc { get; set; } = string.Empty;

    }
}
