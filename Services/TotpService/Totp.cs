using System;

namespace TwoFactorDemo.Services
{
    internal class Totp
    {
        private object p;

        public Totp(object p)
        {
            this.p = p;
        }

        internal bool VerifyTotp(string code, out object _)
        {
            throw new NotImplementedException();
        }
    }
}