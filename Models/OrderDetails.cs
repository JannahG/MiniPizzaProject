namespace MiniPizzaProject.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public string PizzaId { get; set; }
        public int Quantity { get; set; }
    }
}