using Azure.Identity;
using Azure.Storage.Blobs;
using System;

namespace DownloadBlob_ClientCredentials
{
    internal class Program
    {

        public static string tenantID = "6a6849bf-c49a-4310-b411-2dbbfbfba720";
        public static string clientID = "7a64fe82-92b9-4abe-9c5e-c123da63f66f";
        public static string clientSecret = "xod8Q~H-iH~xXU6siK-ycER.1VwiFQ6y5bqh.bc2";
        public static string downloadPath = "C:\\Test\\sampleImage.jpg";



        static void Main(string[] args)
        {
            DownloadBlob();        
        
        }

        public static void DownloadBlob()
        {
            string blobURL = "https://quickcartstorage.blob.core.windows.net/products/shirt.jpg";

            ClientSecretCredential clientCredential = new ClientSecretCredential(tenantID, clientID, clientSecret);
            Uri blobUri = new Uri(blobURL);
            BlobClient blobClient = new BlobClient(blobUri, clientCredential);
            blobClient.DownloadTo(downloadPath);
            Console.WriteLine("Blob Downloaded!");
        }


    }
}
