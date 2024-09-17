﻿using System.ComponentModel.DataAnnotations;

namespace ChatterServiceApi.Models;

public class AccountName
{
    [Key]
    public int Id {get; set;}
    public string Value {get; set;}
}