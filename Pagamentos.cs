  
using System;
namespace Aula08Abstracao
{
    public class Pagamentos
    {
        public DateTime data{get; set; }
        public int valor { get; set; }
        
        
        public string Pagar(float valorPago ){
            return "Valor  pago: R$"+valorPago;
        }
        public string Cancelar(){
            return "pagamennto cancelado";
        }
        
    }
}