namespace CustomCache
{
    internal class SlowDataDownloader : IDataDownloader
    {
       
        public string DownloadData(string resourceId)
        {
            // Assuming it takes a while to perform operations.
            Thread.Sleep(1000);

            return $"Some data for {resourceId}";
        }
    }
}