using System;
using System.Web;

namespace Blog.SlightEdgeCoder.NinjectHttpContext.WebSite.Utilities
{
    public class QueryArgParser
    {
        public HttpContext HttpContext { get; set; }

        public QueryArgParser(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }

        public string GetConnectionString()
        {
            string dbValue = HttpContext.Request.QueryString["db"];
            switch (dbValue)
            {
                case "prod":
                    return @"Server=GODDESS\SQL2014;Initial Catalog=AdventureWorks2014;Integrated Security=SSPI";
                case "stage":
                    return @"Server=GODDESS\SQL2014;Initial Catalog=AdventureWorks2014Stage;Integrated Security=SSPI";
                case "dev":
                    return @"Server=GODDESS\SQL2014;Initial Catalog=AdventureWorks2014Dev;Integrated Security=SSPI";
            }

            throw new ArgumentException("Query string doesn't contain \"db\" parameter");
        }
    }
}