namespace TwoFactorDemo.Controllers
{
    internal class User
    {
        public object Username { get; set; }
        public object PasswordHash { get; set; }
        public object TotpSecret { get; set; }
    }
}