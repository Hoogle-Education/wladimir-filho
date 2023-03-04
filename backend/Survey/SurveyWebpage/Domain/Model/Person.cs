namespace Survey.Domain.Model; 

public class Person : Entity {
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Email { get; set; }
    
    public AgeRange AgeRange{ get; set; }

    public DateTime? BirthDate { get; set; }

    public Gender? Gender { get; set; } = null!;

}