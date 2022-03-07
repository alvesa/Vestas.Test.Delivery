using System;
using System.ComponentModel.DataAnnotations;

namespace Vestas.Test.Delivery.Application.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PassCode { get; set; }
        public string Role { get; set; }
    }
}