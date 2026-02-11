namespace TwoFactorDemo.Data
{
    public class DbContext
    {
        private DbContextOptions<AppDBContext> options;
        private DBContextOptions<AppDBContext> options1;

        public DbContext(DbContextOptions<AppDBContext> options)
        {
            this.options = options;
        }

        public DbContext(DBContextOptions<AppDBContext> options1)
        {
            this.options1 = options1;
        }
    }
}