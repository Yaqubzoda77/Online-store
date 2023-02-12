using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public OrderService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<Response<OrderDto>> GetOrderById(int Id)
    {
        var response = await _context.Orders.FindAsync(Id);
        var mapped = _mapper.Map<OrderDto>(response);
        return new Response<OrderDto>(mapped);
    }
    
   
    
    public async Task<Response<DoOrder>> AddOrder(DoOrder doOrder)
    {
        var mapped = _mapper.Map<Order>(doOrder);
        await _context.Orders.AddAsync(mapped);
        await _context.SaveChangesAsync();
                
        return new Response<DoOrder>(_mapper.Map<DoOrder>(mapped));
    }
}