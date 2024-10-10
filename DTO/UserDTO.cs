﻿namespace Dot_Net_ECommerceWeb.DTO;

public class UserDTO
{
    public int id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string FullName { get; set; }
    public string Gender { get; set; }
    public DateTime? Birthday { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Avatar { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
    public string TypeLogin { get; set; }
}