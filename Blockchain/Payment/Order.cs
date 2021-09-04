using System;
namespace Blockchain.Payment
{
    public class Order
    {
        public int Id { get; set; } // id
        public DateTime? Date { get; set; } // дата
        public decimal Sum { get; set; } // сумма заказа
        public string Sender { get; set; } // отправитель
        public int? UserId { get; set; } // id пользователя в системе, который сделал заказ
    }
}
