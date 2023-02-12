using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CustomerService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public CustomerService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
  
    
    public async Task<Response<CustomerDto>> GetCustomerById(int id)
    {
        var response = await _context.Customers.FindAsync(id);
        var mapped = _mapper.Map<CustomerDto>(response);
        return new Response<CustomerDto>(mapped);
    }

    public async Task<Response<CustomerDto>> AddCustomer(CustomerDto customerDto)
    {
        var mapped = _mapper.Map<Customer>(customerDto);
        await _context.Customers.AddAsync(mapped);
        await _context.SaveChangesAsync();
                
        return new Response<CustomerDto>(_mapper.Map<CustomerDto>(mapped));
    } 
}