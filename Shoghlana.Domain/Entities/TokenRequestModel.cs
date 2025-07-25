﻿using System.ComponentModel.DataAnnotations;

namespace Shoghlana.Domain.Entities;
public class TokenRequestModel
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
