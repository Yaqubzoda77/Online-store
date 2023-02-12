using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }

    public Customer Customer { get; set; }
    public int CustomerId { get; set; }  
    public Product Product { get; set; }
    public int  ProductId { get; set; }

    public Order()
    {
        
    }

    public Order(int id, Customer customer, int customerId, Product product, int productId)
    {
        Id = id;
        Customer = customer;
        CustomerId = customerId;
        Product = product;
        ProductId = productId;
    }
}