namespace TwoFactorDemo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DBContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DBSet<User> Users { get; set; }
    }
}
