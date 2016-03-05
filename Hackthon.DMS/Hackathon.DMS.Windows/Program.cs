using Hackathon.DMS.Windows.SystemTray;
using Microsoft.Win32;
using System;
using System.Timers;
using System.Windows.Forms;

namespace Hackathon.DMS.Windows
{
    static class Program
    {
        #region Global Declaration  
        public static string deviceName = "";
        public static Boolean IsPause = false;

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue("Hackhathon", Application.ExecutablePath.ToString());            

            CommanOperation serviceImpl = new CommanOperation();
             deviceName = Environment.MachineName;
            serviceImpl.SaveIfNotRegister(deviceName);           

            int interval = 1;
            Timer(interval);
            System.Threading.Thread guiThread = new System.Threading.Thread(startGui);
            guiThread.Start();
            Application.Run();
        }
        static void startGui()
        {
            IdsProcessIcon pIcon = new IdsProcessIcon();
            {
                pIcon.Display();
                Application.Run();
            }
        }
        public static void Timer(int interval)
        {
            System.Timers.Timer timer;
            timer = new System.Timers.Timer(60 * 1000 * interval);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
            timer.Start();
        }

        public static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CommanOperation d = new CommanOperation();
            d.GetDeviceDetails(deviceName);
            if (!IsPause)
            {
                string folderPath = Application.StartupPath;
                d.CaptureDeviceScreen(folderPath + "\\test\\", deviceName);
            }
        }
    }
}
