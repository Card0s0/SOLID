namespace _3LSP
{
    public class ClienteOuro : Cliente
    {
        public override double Desconto()
        {
            return ValorTotal - 100;
        }
    }
}