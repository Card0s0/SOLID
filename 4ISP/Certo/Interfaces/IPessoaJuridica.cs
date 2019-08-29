namespace _4ISP.Certo.Interfaces
{
    public interface IPessoaJuridica : IPessoa
    {
        string Cnpj { get; set; }

    }
}