using Hackathon.DMS.Windows.Blob;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Hackathon.DMS.Windows
{
    class CommanImpl
    {
        #region take screenshot
        public void TakeScreenshot()
        {
            string folderPath = Application.StartupPath;
            folderPath = folderPath + "\\test\\";
            DeleteFiles(folderPath);
            CaptureDeviceScreen(folderPath);
        }

        /// <summary>
        /// To delete all files
        /// </summary>
        /// <param name="path"></param>
        public void DeleteFiles(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (FileInfo fl in dir.GetFiles())
                {
                    fl.Delete();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// To capture screenshot
        /// </summary>
        /// <param name="folderPath"></param>
        public void CaptureDeviceScreen(string folderPath)
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                string filePath = @folderPath + System.DateTime.Now.TimeOfDay.Milliseconds + ".jpg";
                bitmap.Save(filePath, ImageFormat.Jpeg);
                new Upload().UploadFile(filePath);
            }
        }

        /// <summary>
        /// Get Machin name
        /// </summary>
        public string GetDeviceName()
        {
            try
            {
                return Environment.MachineName;                
            }
            catch (Exception)
            {
                return "Defualt Device";
            }
        }

        /// <summary>
        /// To shutdown system
        /// </summary>
        public void ShutDownSystem()
        {
            try
            {
                Process.Start("shutdown", "/s /t 0");
            }
            catch (Exception)
            {
                throw;
            }
        }
       #endregion
    }
}
