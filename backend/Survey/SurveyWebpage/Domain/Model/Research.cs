﻿using Survey.Domain.Interfaces;

namespace Survey.Domain.Model; 

public class Research : Entity {

    public Person Person { get; set; } = null!;

    public Adress Adress { get; set; } = null!;

    public DateTime? RespondedAt { get; set; } = null!;
    
    public List<string> BankName { get; set; } = null!;

    public string Newspaper { get; set; } = null!;

    public string IpAdress { get; set; } = null!;

}