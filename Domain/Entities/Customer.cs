namespace Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NumberPhone { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
        
    }

    public Customer(int id, string firstName, string lastName, string numberPhone)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        NumberPhone = numberPhone;
    }
}