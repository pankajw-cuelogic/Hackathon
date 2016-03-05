using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.DMS.Windows.Blob
{
   public class Upload
    {
        /// <summary>
        /// Upload file to blob storage
        /// </summary>
        /// <param name="filePath"></param>
        public void UploadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream ms = new MemoryStream();
                fs.CopyTo(ms);
                FileModel file = new FileModel();
                file.FileName = filePath.Contains("\\") ? filePath.Split('\\')[filePath.Split('\\').Count() - 1] : filePath;
                file.FileMime = "image/jpg";
                file.FileBytes = ms.ToArray();

                UploadFileToBlob(file);
            }
        }

        /// <summary>
        /// Upload file to blob storage. input Custome file object
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool UploadFileToBlob(FileModel file)
        {
            CloudBlobContainer _container = AzureBlobUtilities.GetBlobClient.GetContainerReference("screenpath");
            _container.CreateIfNotExists();

            // Get reference to blob (binary content)
            CloudBlockBlob blockBlob = _container.GetBlockBlobReference(file.FileName);

            // set its properties
            blockBlob.Properties.ContentType = file.FileMime;
            blockBlob.Metadata["filename"] = file.FileName;
            blockBlob.Metadata["filemime"] = file.FileMime;

            // Get stream from file bytes
            Stream stream = new MemoryStream(file.FileBytes);

            // Async upload of stream to Storage
            AsyncCallback uploadCompleted = new AsyncCallback(OnUploadCompleted);
            blockBlob.BeginUploadFromStream(stream, uploadCompleted, blockBlob);

            return true;
        }
        private void OnUploadCompleted(IAsyncResult result)
        {
            CloudBlockBlob blob = (CloudBlockBlob)result.AsyncState;
            blob.SetMetadata();
            blob.EndUploadFromStream(result);
        }
    }
}
