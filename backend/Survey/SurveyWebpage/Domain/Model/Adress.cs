using Survey.Domain.Interfaces;

namespace Survey.Domain.Model; 

public class Adress : Entity {
    
    public string Postcode { get; set; } = null!;

    public string? HomeSuburb { get; set; }

    public string State { get; set; } = null!;
    public Research Research { get; set; } = null!;
    
    public int ResearchId { get; set; }

}