using _4ISP.Certo.Interfaces;

namespace _4ISP
{
    public class PessoaFisica : IPessoaFisica
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
       
        public void IsValid()
        {
            //Validar Cpf
        }
    }
}