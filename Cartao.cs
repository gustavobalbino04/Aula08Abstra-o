namespace Aula08Abstracao
{
    public class Cartao: Pagamentos
    {
        public string token = "432534878273ingjbu3h8t18";
        public string  bandeira  { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        public string cvv { get; set; }
       // public string bandeira { get; set;}

        public bool ValidorToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}