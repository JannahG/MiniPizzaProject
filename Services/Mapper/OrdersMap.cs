using CsvHelper.Configuration;
using MiniPizzaProject.Models;

namespace MiniPizzaProject.Services.Mapper
{
    public class OrdersMap : ClassMap<Order>
    {
        public OrdersMap()
        {
            Map(m => m.OrderId).Name("order_id");
            Map(m => m.Date).Name("date");
            Map(m => m.Time).Name("time");
        }
    }
}