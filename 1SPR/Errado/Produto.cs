namespace _1SPR.Errado
{
    public class Produto{
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public void Adicionar(){
            try
            {
                if (string.IsNullOrEmpty(Nome)) throw new System.ArgumentNullException(Nome);
                if (string.IsNullOrEmpty(Nome)) throw new System.ArgumentNullException(Descricao);

                using (var conn = new SqlConnection())
                {
                    var command = new SqlCommand
                    {
                        CommandText = "INSERT INTO PRODUTO(Nome,Descricao) VALUES (@nome,@descricao)"
                    };
                    command.Parameters.AddWithValue("Nome",Nome);
                    command.Parameters.AddWithValue("descricao",Descricao);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Error.txt",ex.ToString());
                throw ex;
            }
        }  
    }
}