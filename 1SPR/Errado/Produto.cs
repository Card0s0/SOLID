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

                
            }
            catch (System.Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Error.txt",ex.ToString());
                throw ex;
            }
        }  
    }
}