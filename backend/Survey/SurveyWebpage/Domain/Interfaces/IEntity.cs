﻿namespace Survey.Domain.Interfaces; 

public interface IEntity {
    public int Id { get; set; }
    
}

public abstract class Entity : IEntity {
    
    public int Id { get; set; }
    
}