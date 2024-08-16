using CsvHelper.Configuration;
using MiniPizzaProject.Models;

namespace MiniPizzaProject.Services.Mapper
{
    public class PizzasMap : ClassMap<Pizza>
    {
        public PizzasMap()
        {
            Map(m => m.PizzaId).Name("pizza_id");
            Map(m => m.PizzaTypeId).Name("pizza_type_id");
            Map(m => m.Size).Name("size");
            Map(m => m.Price).Name("price");
        }
    }
}