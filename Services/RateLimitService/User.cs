namespace TwoFactorDemo.Services
{
    public class User
    {
        public int FailedAttempts { get; internal set; }
        public object LockoutEnd { get; internal set; }
    }
}