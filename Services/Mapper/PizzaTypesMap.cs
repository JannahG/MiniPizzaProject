using CsvHelper.Configuration;
using MiniPizzaProject.Models;

namespace MiniPizzaProject.Services.Mapper
{
    public class PizzaTypesMap : ClassMap<PizzaType>
    {
        public PizzaTypesMap()
        {
            Map(m => m.PizzaTypeId).Name("pizza_type_id");
            Map(m => m.Name).Name("name");
            Map(m => m.Category).Name("category");
            Map(m => m.Ingredients).Name("ingredients");
        }
    }
}