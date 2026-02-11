namespace TwoFactorDemo.Services
{
    public class QrCodeService
    {
        public byte[] GenerateQrCode(string uri)
        {
            using QRCodeGenerator generator = new QRCodeGenerator();
            var data = generator.CreateQrCode(uri, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(data);
            return qrCode.GetGraphic(20);
        }

builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<TotpService>();
builder.Services.AddScoped<QrCodeService>();
builder.Services.AddScoped<RateLimitService>();
    }
}