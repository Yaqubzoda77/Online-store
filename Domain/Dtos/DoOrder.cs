using Microsoft.VisualBasic;

namespace Domain.Dtos;

public class DoOrder
{
    
    public int Id { get; set; }
    public int CustomerId { get; set; }  
    public int ProductId { get; set; }

    public DoOrder()
    {
        
    }

    public DoOrder(int id, int customerId, int productId)
    {
        Id = id;
        CustomerId = customerId;
        ProductId = productId;
    }
}