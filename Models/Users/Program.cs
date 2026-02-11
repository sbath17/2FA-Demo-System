using System;

namespace TwoFactorDemo.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string TotpSecret { get; set; }

        public int FailedAttempts { get; set; }

        public DateTime LockoutEnd { get; set; }
    }
}