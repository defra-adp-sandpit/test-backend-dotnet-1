﻿using System.ComponentModel.DataAnnotations;

namespace Test.Backend.Dotnet.1.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

