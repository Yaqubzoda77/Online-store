using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class OrderController
{
    
    
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }
    
    
        
    [HttpGet("GetOrderById")]
    public async Task<Response<OrderDto>> GetOrderById(int id)
    {
        return await _orderService.GetOrderById(id);
    }
    
  
    
 
    [HttpPost("YouCanOrder")]
    public async Task YouCanOrder(DoOrder doOrder)
    {
        await _orderService.AddOrder(doOrder);
    }

}