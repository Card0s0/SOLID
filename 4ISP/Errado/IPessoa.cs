namespace _4ISP.Errado
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Email { get; set; }
        string Cpf { get; set; }
        string Cnpj { get; set; }

        void ValidaCpf();
        void ValidaCnpj();

    }
}