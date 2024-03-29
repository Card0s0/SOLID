namespace _2OCP.Errado
{
    public class Cliente{

        public enum ClienteTipoEnum{
            PessoaFisica,
            PessoaJuridica
        }

        public ClienteTipoEnum ClienteTipo {get; set; }
        public int ClienteId { get; set; }
        public string NomeFisico { get; set; }
        public string NomeFantasia { get; set; }

        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public List<string> Telefones { get; set; }
        
    }
}