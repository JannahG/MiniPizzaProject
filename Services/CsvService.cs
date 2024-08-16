using MiniPizzaProject.Models;
using MiniPizzaProject.Services;
using MiniPizzaProject.Services.Mapper;

public class CsvService
{
    public IEnumerable<OrderDetails> GetOrderDetails()
    {
        return CsvDataReaderHelper.ReadFromCsv<OrderDetails>("order_details.csv", new OrderDetailsMap());
    }

    public IEnumerable<Order> GetOrders()
    {
        return CsvDataReaderHelper.ReadFromCsv<Order>("orders.csv", new OrdersMap());
    }

    public IEnumerable<PizzaType> GetPizzaTypes()
    {
        return CsvDataReaderHelper.ReadFromCsv<PizzaType>("pizza_types.csv", new PizzaTypesMap());
    }

    public IEnumerable<Pizza> GetPizzas()
    {
        return CsvDataReaderHelper.ReadFromCsv<Pizza>("pizzas.csv", new PizzasMap());
    }
}
