using _4ISP.Certo.Interfaces;

namespace _4ISP
{
    public class PessoaJuridica : IPessoaJuridica
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
       
        public void IsValid()
        {
            //Validar Cnpj
        }
    }
}