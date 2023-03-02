namespace Survey.Domain.Model; 

public class Adress {
    
    public string Postcode { get; set; } = null!;

    public string? HomeSuburb { get; set; }

    public string State { get; set; } = null!;
    
}