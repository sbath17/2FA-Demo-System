using System;
using BCrypt.Net;

namespace TwoFactorDemo.Services
{
    public class PasswordService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<TotpService>();
builder.Services.AddScoped<QrCodeService>();
builder.Services.AddScoped<RateLimitService>();
    }
}
