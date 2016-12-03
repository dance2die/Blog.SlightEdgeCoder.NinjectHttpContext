namespace Blog.SlightEdgeCoder.NinjectHttpContext.Dal
{
    public class Repository : IRepository
    {
        public string ConnectionString { get; set; }

        public Repository(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}