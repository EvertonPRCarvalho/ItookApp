﻿namespace ItookApp.Endpoints.Categories;

public class CategoryRequest
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}