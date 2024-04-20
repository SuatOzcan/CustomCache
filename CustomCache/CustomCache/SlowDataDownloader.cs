namespace CustomCache
{
    internal class SlowDataDownloader : IDataDownloader
    {
        private readonly Cache<string,string> _cache = new();
        public SlowDataDownloader()
        {
        }

        public string DownloadData(string resourceId)
        {
            return _cache.Get(resourceId, DownloadDataWithoutCaching);
        }
        public string DownloadDataWithoutCaching(string resourceId)
        {
            // Assuming it takes a while to perform operations.
            Thread.Sleep(1000);

            return $"Some data for {resourceId}";
        }
    }
}