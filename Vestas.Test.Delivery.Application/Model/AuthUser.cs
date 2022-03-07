using System;
using System.ComponentModel.DataAnnotations;

public class AuthUser
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PassCode { get; set; }
    public string Role { get; set; }
}