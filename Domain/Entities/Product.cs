using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name  { get; set; }
    public decimal Price { get; set; }
    public int InstallmentRange { get; set; }

    public List<Order> Orders { get; set; }

    public Product()
    {
        
    }

    public Product(int id, string name, decimal price,int installmentRange)
    {
        Id = id;
        Name = name;
        Price = price;
        InstallmentRange = installmentRange;
    }
}