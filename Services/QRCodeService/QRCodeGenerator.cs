using System;

namespace TwoFactorDemo.Services
{
    internal class QRCodeGenerator
    {
        public QRCodeGenerator()
        {
        }

        public static object ECCLevel { get; internal set; }

        internal object CreateQrCode(string uri, object q)
        {
            throw new NotImplementedException();
        }
    }
}