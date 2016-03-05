using Hackathon.DMS.Windows.SystemTray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Hackathon.DMS.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           
            //Api name
            //CommanImpl comm = new CommanImpl();
            string  DeviceName = Environment.MachineName;
            int interval = 2;
            Timer(interval);
            //comm.SaveDeviceIfNotExists(DeviceName);
            System.Threading.Thread guiThread = new System.Threading.Thread(startGui);
            guiThread.Start();
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
            string folderPath = Application.StartupPath;
            CommanImpl d = new CommanImpl();
            d.DeleteFiles(folderPath);
            d.CaptureDeviceScreen(folderPath + "\\test" + System.DateTime.Now.TimeOfDay.Ticks + ".jpg");
        }
    }
}
