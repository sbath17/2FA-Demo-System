using System;
using TwoFactorDemo.Data;
using TwoFactorDemo.Models;

namespace TwoFactorDemo.Services
{
    public class RateLimitService
    {
        private readonly AppDBContext _db;

        public RateLimitService(AppDBContext db) => _db = db;

        public bool IsLockedOut(User user)
        {
            if (user.LockoutEnd == null)
                return false;

            return user.LockoutEnd >= DateTime.UtcNow;
        }

        public void RegisterFailedAttempt(User user)
        {
            user.FailedAttempts++;

            if (user.FailedAttempts >= 5)
            {
                user.LockoutEnd = DateTime.UtcNow.AddMinutes(5);
                user.FailedAttempts = 0;
            }

            _db.SaveChanges();
        }

        public void ResetAttempts(User user)
        {
            user.FailedAttempts = 0;
            user.LockoutEnd = null;
            _db.SaveChanges();
        }

builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<TotpService>();
builder.Services.AddScoped<QrCodeService>();
builder.Services.AddScoped<RateLimitService>();
    }
}