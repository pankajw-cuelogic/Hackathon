using Hackathon.DMS.Windows.Blob;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Hackathon.DMS.Windows
{
    class CommanOperation
    {
        #region take screenshot
        public void TakeScreenshot(string deviceName)
        {
            string folderPath = Application.StartupPath;
            folderPath = folderPath + "\\test\\";
            DeleteFiles(folderPath);
            CaptureDeviceScreen(folderPath, deviceName);
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
       /// Caupture screenshot
       /// </summary>
       /// <param name="folderPath"></param>
       /// <param name="deviceName"></param>
        public void CaptureDeviceScreen(string folderPath, string deviceName)
        {
            DeleteFiles(folderPath);

            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }               

                string filePath = @folderPath + System.DateTime.Now.TimeOfDay.Ticks + ".jpg";
                bitmap.Save(filePath, ImageFormat.Jpeg);
                new Upload().UploadFile(filePath);
                new Upload().SaveScreenshot(filePath.Contains("\\") ? filePath.Split('\\')[filePath.Split('\\').Count() - 1] : filePath, deviceName);
            }
        }

       /// <summary>
       /// Save Device if not registered. 
       /// </summary>
       /// <param name="DeviceId"></param>
        public void SaveIfNotRegister(string DeviceId)
        {
            new Upload().SaveDeviceIfNotRegister(DeviceId);
        }

        public void GetDeviceDetails(string DeviceId)
        {
           var Device= new Upload().GetDeviceDetails(DeviceId);

            if (Device != null)
            {
                Program.IsPause = Device.IsPause == true ? true : false;

                if (Device.IsShutdownDevice == true)
                {
                    ShutDownSystem();
                }
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
