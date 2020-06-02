using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
             {
           

            CartaoCredito visa = new CartaoCredito();
            visa.limite = 400055f;

            Console.WriteLine("Quanto acrescentar no limite?");
            float acres = float.Parse( Console.ReadLine() );
            
            visa.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$ "+visa.limite);

            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine() );
            
            System.Console.WriteLine("Data: " + visa.data);


           

        }
        }
    }
}
