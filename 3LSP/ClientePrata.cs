namespace _3LSP
{
    public class ClientePrata : Cliente
    {
        public override double Desconto()
        {
            return ValorTotal - 50;
        }
        
    }
}