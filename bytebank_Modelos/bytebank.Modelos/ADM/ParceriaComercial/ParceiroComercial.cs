using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    internal class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil? Autenticador { get; set; }
        public bool Autenticar(string senha)
        {
            return Autenticador.ValidarSenha(Senha, senha);
        }
    }
}
