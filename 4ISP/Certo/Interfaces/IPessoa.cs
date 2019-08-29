namespace _4ISP.Certo.Interfaces
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Email { get; set; }
       
        void IsValid();
    }
}