using _31_Enumeracoes.Enums;
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

            //Conversões
            //    Para o tipo original: use casting
            //    OrderStatus os1 = (OrderStatus)2;
            //            int n1 = (int)OrderStatus.Processing;
            //            string - enum:
            //            string txt = OrderStatus.PendingPayment.ToString();

            //1ºforma
            //    OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            //            Console.WriteLine(os);
            //            Console.WriteLine(txt);

            //2º forma
            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            //3º forma
            //OrderStatus os;
            //Enum.TryParse("Delivered", out os);

            Order order = new Order
            {
                Id = 10800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

                Console.WriteLine(os);
                Console.WriteLine(txt);
        }
    }
}
