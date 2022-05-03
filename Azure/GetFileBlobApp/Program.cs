using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace GetFileBlobApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            MainAsync().GetAwaiter().GetResult();
            Console.ReadKey();
        }
        static async Task MainAsync()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=g3storagemay22;AccountKey=woAeqI90K9qrLA/spMs9xesJcYvX2IeNNQ06QrxCJ43wjYaYyV5uaVUugUxFTVQuyOtOB6lt7q1n+AStdL7gDQ==;EndpointSuffix=core.windows.net";
            var containerName = "g3blob";
            var serviceClient = new BlobServiceClient(connectionString);
            var containerClient = serviceClient.GetBlobContainerClient(containerName);
            //string path = @"D:\blob";
            //var filename = "Pic1.jpg";
            //var localFile = Path.Combine(path, filename);
            var blobClient = containerClient.GetBlobClient("Pic1.jpg");
            var download = await blobClient.DownloadContentAsync();
            FileStream downloadFileStream = File.OpenWrite(@"D:\blob\downloadPic1.jpg");
            await download.Value.Content.ToStream().CopyToAsync(downloadFileStream);
            downloadFileStream.Close();
        }
    }
}
