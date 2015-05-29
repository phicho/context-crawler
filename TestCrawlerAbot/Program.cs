using log4net.Config;
namespace TestCrawlerAbot
{
    class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            var crawler = new CrawlerWrapper();
            crawler.Crawl("http://www.savana.com.mk/");
        }
    }
}
