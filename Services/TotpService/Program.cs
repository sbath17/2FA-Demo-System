using System;
using OtpNet;

namespace TwoFactorDemo.Services
{
    public class TotpService
    {
        public object Base32Encoding { get; private set; }
        public object KeyGeneration { get; private set; }

        public string GenerateSecret()
        {
            var bytes = KeyGeneration.GenerateRandomKey(20);
            return Base32Encoding.ToString(bytes);
        }

        public bool VerifyCode(string secret, string code)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secret));
            return totp.VerifyTotp(code, out _);
        }

        public string GetProvisioningUri(string secret, string username, string issuer)
        {
            return $"otpauth://totp/{issuer}:{username}?secret={secret}&issuer={issuer}";
        }

builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<TotpService>();
builder.Services.AddScoped<QrCodeService>();
builder.Services.AddScoped<RateLimitService>();
    }
}