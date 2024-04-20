namespace CustomCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataDownloader dataDownloader = new CachingDataDownloader(new SlowDataDownloader());

            Console.WriteLine(dataDownloader.DownloadData("id1"));
            Console.WriteLine(dataDownloader.DownloadData("id2"));
            Console.WriteLine(dataDownloader.DownloadData("id3"));
            Console.WriteLine(dataDownloader.DownloadData("id1"));
            Console.WriteLine(dataDownloader.DownloadData("id2"));
            Console.WriteLine(dataDownloader.DownloadData("id3"));
            Console.WriteLine(dataDownloader.DownloadData("id1"));
            Console.WriteLine(dataDownloader.DownloadData("id2"));
            Console.WriteLine(dataDownloader.DownloadData("id3"));
        }
    }
}