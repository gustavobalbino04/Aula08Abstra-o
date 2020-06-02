using System;
namespace Aula08Abstracao
{
    public class Boleto : Pagamentos 
    {
        public DateTime dataVencimeto { get; set; }
        public string bancoEmissor { get; set; }
        public string codDeBarras { get; set; }
        
        public string Registrar(){
            return "Boleto registrado com suceso!";
        }
        
    }
}