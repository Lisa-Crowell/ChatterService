﻿using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class DomainName
{
    [Key]
    public int Id {get; set;}
    public string Value {get; set;}
}