using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache
{
    internal interface IDataDownloader
    {
        string DownloadData(string resourceId);
    }
}
