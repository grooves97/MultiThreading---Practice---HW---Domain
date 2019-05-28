using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace BigVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("ftp://videodarom:1169@videodarom.no-ip.org/Alpha.2018.BDRip.VideoDarom.ru.mkv", "Emilia Clarke");
                Console.ReadLine();
            }
        }
        
        //public Stream DownloadToStream(string url)
        //{
        //    using (var webClient = new System.Net.WebClient())
        //    {
        //        byte[] data = webClient.DownloadData(url);
        //        var ms = new System.IO.MemoryStream(data);
        //        return ms;
        //    }
        //}
    }
}
