using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Hackathon.DMS.Web.Blob
{
    public class Download
    {
        public byte[] DownloadFileFromBlob(string fileName)
        {
            // Get Blob Container
            CloudBlobContainer _container = AzureBlobUtilities.GetBlobClient.GetContainerReference("screenpath");
            // Get reference to blob (binary content)
            CloudBlockBlob blockBlob = _container.GetBlockBlobReference(fileName);
            // Read content
            using (MemoryStream ms = new MemoryStream())
            {
                blockBlob.DownloadToStream(ms);
                return ms.ToArray();
            }
        }
    }
}