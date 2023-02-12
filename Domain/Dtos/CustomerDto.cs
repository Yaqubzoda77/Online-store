namespace Domain.Dtos;

public class CustomerDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NumberPhone { get; set; }

    public CustomerDto()
    {
        
    }

    public CustomerDto(int id, string firstName, string lastName, string numberPhone)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        NumberPhone = numberPhone;
    }
}