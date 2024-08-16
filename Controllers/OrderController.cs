using Microsoft.AspNetCore.Mvc;
using MiniPizzaProject.Services.Helpers;

[Route("api/pizza-project")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly CsvService _csvService;

    public OrderController()
    {
        _csvService = new CsvService();
    }

    [HttpGet("order-details")]
    public IActionResult GetOrderDetails([FromQuery] PaginationParameters parameters)
    {
        if (parameters.PageNumber < 1) parameters.PageNumber = 1;
        if (parameters.PageSize < 1) parameters.PageSize = 10;
        if (parameters.PageSize > 100) parameters.PageSize = 100;

        var orderDetails = _csvService.GetOrderDetails().AsQueryable();
        var pagedResult = PaginationHelper.GetPaged(orderDetails, parameters);

        return Ok(pagedResult);
    }

    [HttpGet("orders")]
    public IActionResult GetOrders([FromQuery] PaginationParameters parameters)
    {
        if (parameters.PageNumber < 1) parameters.PageNumber = 1;
        if (parameters.PageSize < 1) parameters.PageSize = 10;
        if (parameters.PageSize > 100) parameters.PageSize = 100;

        var orders = _csvService.GetOrders().AsQueryable();
        var pagedResult = PaginationHelper.GetPaged(orders, parameters);
        
        return Ok(pagedResult);
    }

    [HttpGet("pizza-types")]
    public IActionResult GetPizzaTypes([FromQuery] PaginationParameters parameters)
    {
        if (parameters.PageNumber < 1) parameters.PageNumber = 1;
        if (parameters.PageSize < 1) parameters.PageSize = 10;
        if (parameters.PageSize > 100) parameters.PageSize = 100;

        var pizzaTypes = _csvService.GetPizzaTypes().AsQueryable();
        var pagedResult = PaginationHelper.GetPaged(pizzaTypes, parameters);

        return Ok(pagedResult);
    }

    [HttpGet("pizzas")]
    public IActionResult GetPizzas([FromQuery] PaginationParameters parameters)
    {
        if (parameters.PageNumber < 1) parameters.PageNumber = 1;
        if (parameters.PageSize < 1) parameters.PageSize = 10;
        if (parameters.PageSize > 100) parameters.PageSize = 100;

        var pizzas = _csvService.GetPizzas().AsQueryable();
        var pagedResult = PaginationHelper.GetPaged(pizzas, parameters);

        return Ok(pagedResult);
    }
}