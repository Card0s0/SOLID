namespace _1SPR.Certo
{
    public class ProdutoRepository{

        public void Add(Produto produto){

            using (var conn = new SqlConnection())
            {
                var command = new SqlCommand
                {
                    CommandText = "INSERT INTO PRODUTO(Nome,Descricao) VALUES (@nome,@descricao)"
                };
                command.Parameters.AddWithValue("Nome",produto.Nome);
                command.Parameters.AddWithValue("descricao",produto.Descricao);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}