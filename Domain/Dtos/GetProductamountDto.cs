namespace Domain.Dtos;

public class GetProductamountDto
{
    public int Id { get; set; }
    public string Name  { get; set; }
    public decimal Price { get; set; }
    public int InstallmentRange { get; set; }
    public string NumberPhone { get; set; }
    public string FullName { get; set; }
}