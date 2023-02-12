using Microsoft.VisualBasic;

namespace Domain.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string NumberPhone { get; set; }
    public string Name  { get; set; }
    public decimal Price { get; set; }
    public string InstallmentRange { get; set; }

    public OrderDto()
    {
        
    }

    public OrderDto( string firstName, string numberPhone, string name, decimal price,  string installmentRange)
    {
        FirstName = firstName;
        NumberPhone = numberPhone;
        Name = name;
        Price = price;
        InstallmentRange = installmentRange;
    }
    
}