using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("[controller]")]

public class CustomerController
{
    
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }
    
     
    
    
    [HttpGet("GetCustomerById")]
    public async Task<Response<CustomerDto>> GetCustomerById(int id)
    {
        return await _customerService.GetCustomerById(id);
    } 
    
 
    [HttpPost("AddCustomer")]
    public async Task AddProduct(CustomerDto customerDto)
    {
        await _customerService.AddCustomer(customerDto);
    }
   
}