namespace _1SPR.Certo
{
    public class ProdutoService{

        private ProdutoRepository _produtoRepository;

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public string Add(Produto prod){
            try
            {
                if (!prod.IsValid) return "Produto Inválido";
                _produtoRepository.Add(prod);
            }
            catch (System.Exception ex)
            {
                FileLogger.Handle(ex.Message.ToString());
                return ex.Message;
            }

            return "Sucesso!!";
        }
    }
}