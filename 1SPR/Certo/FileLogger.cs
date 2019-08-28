namespace _1SPR.Certo
{
    public static class FileLogger{

        public static void Handle(string mensagem)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt",mensagem.ToString());
        }

    }
}