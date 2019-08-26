using System;
using _0079_EnumeracoesEnum.Entities;
using _0079_EnumeracoesEnum.Entities.Enums;

namespace _0079_EnumeracoesEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            //Conversão de String para Enumeração
            string txt = OrderStatus.PendingPayment.ToString();
            //Conversão de Enumeração para String

            Console.WriteLine(txt);
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
