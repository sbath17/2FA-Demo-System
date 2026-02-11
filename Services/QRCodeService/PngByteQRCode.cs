using System;

namespace TwoFactorDemo.Services
{
    internal class PngByteQRCode
    {
        private object data;

        public PngByteQRCode(object data)
        {
            this.data = data;
        }

        internal byte[] GetGraphic(int v)
        {
            throw new NotImplementedException();
        }
    }
}