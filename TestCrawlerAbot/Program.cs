namespace TestCrawlerAbot
{
    class Program
    {
        private static void Main(string[] args)
        {
            var crawler = new CrawlerWrapper();
            crawler.Crawl("http://www.savana.com.mk/");
        }
    }
}
