namespace _1SPR.Certo
{
    public class Produto{
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsValid => !(string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Descricao));
    }
}