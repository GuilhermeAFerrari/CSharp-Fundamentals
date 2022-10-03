using OrderStatusSystem.Entities.Enums;
using System.Text;

namespace OrderStatusSystem.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem ordemItem)
        {
            Items.Add(ordemItem);
        }

        public void RemoveItem(OrderItem ordemItem)
        {
            Items.Remove(ordemItem);
        }

        public double Total()
        {
            double sum = 0.00;

            foreach (var item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
