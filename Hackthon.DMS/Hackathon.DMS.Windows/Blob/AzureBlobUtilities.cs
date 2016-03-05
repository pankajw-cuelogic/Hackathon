using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Hackathon.DMS.Windows.Blob
{
    internal class AzureBlobUtilities
    {
        public static CloudBlobClient GetBlobClient
        {
            get
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=hackathondms;"
                 + "AccountKey=tF+pgh778zZEIF3twEjYsdwzUA+w4cvvn9ZTMGS9eCSSFFS8J+ADAJNZVo2SRs0AqunMmA8sAnhRfg6oPWcJLw==");
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                return blobClient;
            }
        }
    }
}
