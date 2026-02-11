using System;

namespace TwoFactorDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDBContext _db;
        private readonly PasswordService _passwordService;
        private readonly TotpService _totpService;
        private readonly QrCodeService _qrService;

        public object ModelState { get; private set; }

        public AccountController(
            AppDBContext db,
            PasswordService passwordService,
            TotpService totpService,
            QrCodeService qrService)
        {
            _db = db;
            _passwordService = passwordService;
            _totpService = totpService;
            _qrService = qrService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate TOTP secret
            var secret = _totpService.GenerateSecret();

            // Create user
            var user = new User
            {
                Username = model.Username,
                PasswordHash = _passwordService.HashPassword(model.Password),
                TotpSecret = secret
            };

            object p = _db.Users.Add(user);
            _db.SaveChanges();

            // Build provisioning URI
            var uri = _totpService.GetProvisioningUri(secret, user.Username, "TwoFactorDemo");

            // Generate QR code
            var qrBytes = _qrService.GenerateQrCode(uri);

            // Return QR code as PNG
            return File(qrBytes, "image/png");
        }

        private IActionResult View(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }

        private IActionResult File(object qrBytes, string v)
        {
            throw new NotImplementedException();
        }
    }
}