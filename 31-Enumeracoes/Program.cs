using System;

namespace _31_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); NÃO FAZER ASSIM

            //LEMBRETE:Fazer conversão de string para enumeração assim:

            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered")

            //ou assim:

            //OrderStatus os;
            //Enum.TryParse("Delivered", out os);
        }
    }
}
