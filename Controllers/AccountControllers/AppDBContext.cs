using System;

namespace TwoFactorDemo.Controllers
{
    public class AppDBContext
    {
        public object Users { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}