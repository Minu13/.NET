﻿namespace SampleBankingApp.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; } 
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; } 
    }
}
