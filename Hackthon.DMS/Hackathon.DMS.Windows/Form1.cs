﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon.DMS.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   new CommanImpl().GetDeviceName();
            //  new CommanImpl().TakeScreenshot();
            //new CommanImpl().ShutDownSystem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = Application.StartupPath;
            CommanOperation d = new CommanOperation();
            d.CaptureDeviceScreen(folderPath + "\\test\\", Program.deviceName);
        }
    }
}
