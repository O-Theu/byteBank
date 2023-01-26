namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    public class AutenticavelUtil
    {
        public bool ValidarSenha(string senhaCorreta, string senha)
        {
            return senhaCorreta.Equals(senha);
        }
    }
}
