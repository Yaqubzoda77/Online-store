using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("[controller]")]

public class ProductController
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }
      
    [HttpGet("GetProductWithCustomer")]
    public async Task<Response<List<GetProductamountDto>>> GetProductWithCustomer()
    {
        return await _productService.GetProductWithCustomer();
    } 
    
    [HttpGet("GetProductyId")]
    public async Task<Response<ProductDto>> GetProductyId(int id)
    {
        return await _productService.GetProductyId(id);
    } 
    
    [HttpGet("GetTotalAmount")]
    public async Task<Response<ProductDto>> GetTotalAmount()
    {
        return await _productService.GetTotalAmount( "Smartphone" , 1000,6);
    }
    
    
    [HttpPost("AddProduct")]
    public async Task AddProduct(ProductDto productDto)
    {
        await _productService.AddProduct(productDto);
    }
}