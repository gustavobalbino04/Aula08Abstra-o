namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite (float acrescimo){
            token = "brueheroihghe";
            limite = limite + acrescimo;
        }
        public string Bloquear(){
            return "O cartao foi bloqueado";

        }
    }
}