namespace _4ISP.Errado
{
    public class PessoaJuridica : IPessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        public void ValidaCpf()
        {

        }
        public void ValidaCnpj()
        {

        }
    }
}