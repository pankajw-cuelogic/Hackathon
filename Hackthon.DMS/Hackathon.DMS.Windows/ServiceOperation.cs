using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.DMS.Windows
{
   public class ServiceOperation
    {
        #region Global Declartion

        Hack.HackathonServiceClient objServiceTesting = new Hack.HackathonServiceClient();

        #endregion

        public void RegisterDevice(string deviceName)
        {

            SendData(deviceName);
                objServiceTesting = new Hack.HackathonServiceClient();
            Hack.Device deviceObj = new Hack.Device();
          //  deviceObj.CreatedDatetime = System.DateTime.Now;
            deviceObj.DeviceId = deviceName;
            deviceObj.DeviceName= deviceName;
            deviceObj.DeviceStatus = "Online";
            deviceObj.IsDeleted= false;
            deviceObj.IsPause= false;
            deviceObj.IsShutdownDevice= false;
            //deviceObj.UpdatedDatetime= System.DateTime.Now;
            objServiceTesting.TestRequestPOST();//
            objServiceTesting.IsDeviceRegistered(deviceObj);
        }

        public void SendData(string deviceName)
        {
            objServiceTesting = new Hack.HackathonServiceClient();
            Hack.Screenshot screenObj = new Hack.Screenshot();
            screenObj.CreatedDatetime = System.DateTime.Now;
            screenObj.Fk_DeviceId = deviceName;
            screenObj.IsDeleted = false;
            screenObj.ScreenshotPath = "Online";
            objServiceTesting.SaveScreenshotPath(screenObj);
        }
    }
}
