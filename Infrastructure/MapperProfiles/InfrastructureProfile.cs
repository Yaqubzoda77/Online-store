using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.MapperProfiles;

public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
       
        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerDto, Customer>();
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
        CreateMap<Order, DoOrder>();
        CreateMap<DoOrder, Order>();
        CreateMap<Order, OrderDto>();
        CreateMap<OrderDto, Order>();
    }
}