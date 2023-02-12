using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ProductService
{
   
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ProductService(DataContext context, IMapper mapper)
        {
                _context = context;
                _mapper = mapper;
        }
        
        
        
        public async Task<Response<List<GetProductamountDto>>> GetProductWithCustomer()
        {
                var response = await (from p in _context.Products
                                join o in _context.Orders on p.Id equals o.ProductId
                                join c in _context.Customers on o.CustomerId equals c.Id
                                select new GetProductamountDto()
                                {
                                        Id = c.Id,
                                        Name = p.Name,
                                        Price = p.Price,
                                        InstallmentRange = p.InstallmentRange,
                                        NumberPhone = c.NumberPhone,
                                        FullName = string.Concat(c.FirstName + " " + c.LastName), 
                                }).ToListAsync();    
                        
                return new Response<List<GetProductamountDto>>(response);
        }
        
        
        
        public async Task<Response<ProductDto>> GetProductyId(int id)
        {
                var response = await _context.Products.FindAsync(id);
                var mapped = _mapper.Map<ProductDto>(response);
                return new Response<ProductDto>(mapped);
        }
        public async Task<Response<ProductDto>> AddProduct(ProductDto productDto)
        {
                var mapped = _mapper.Map<Product>(productDto);
                await _context.Products.AddAsync(mapped);
                await _context.SaveChangesAsync();
                
                return new Response<ProductDto>(_mapper.Map<ProductDto>(mapped)); 
        }

   
        
        public  async Task<Response<ProductDto>>     GetTotalAmount( string product, double amount,  int installmentRange) 
        { 
                double totalAmount = 0;
                switch (product) 
                { 
                        case "Smartphone": 
                                if (installmentRange > 3 && installmentRange < 9) 
                                { 
                                        totalAmount = amount * (1 + ((double)installmentRange / 100)); 
                                } 
                                else 
                                { 
                                        throw new Exception("Invalid installment range for Smartphone"); 
                                } 
                                break; 
                        case "Computer": 
                                if (installmentRange > 3 && installmentRange < 12) 
                                { 
                                        totalAmount = amount * (1 + ((double)installmentRange / 100)); 
                                } 
                                else 
                                { 
                                        throw new Exception("Invalid installment range for Computer");  
                                } 
                                break;
                        case "TV": 
                                if (installmentRange > 3 && installmentRange < 18)  
                                {  
                                        totalAmount = amount * (1 + ((double)installmentRange / 100));  
                                }  
                                else  
                                {  
                                        throw new Exception("Invalid installment range for TV");   
                                }  
                                break;
                        default: 
                                throw new Exception("Invalid product");  
                }
                return new Response<ProductDto>(_mapper.Map<ProductDto>(totalAmount)); 

                

        } 
}
