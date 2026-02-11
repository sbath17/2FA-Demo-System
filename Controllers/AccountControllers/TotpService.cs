using System;

namespace TwoFactorDemo.Controllers
{
    public class TotpService
    {
        internal object GenerateSecret()
        {
            throw new NotImplementedException();
        }

        internal object GetProvisioningUri(object secret, object username, string v)
        {
            throw new NotImplementedException();
        }
    }
}