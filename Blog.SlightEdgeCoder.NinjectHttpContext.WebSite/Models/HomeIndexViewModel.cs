namespace Blog.SlightEdgeCoder.NinjectHttpContext.WebSite.Models
{
    public class HomeIndexViewModel
    {
        public string ConnectionString { get; }

        public HomeIndexViewModel(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}