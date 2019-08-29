namespace _3LSP
{
    public abstract class Cliente 
    {
        public double ValorTotal { get; set; }

        public virtual double Desconto()
        {
            return ValorTotal;
        }
    }
}