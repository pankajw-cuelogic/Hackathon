using Hackathon.DMS.DataLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.DMS.DataLayer.DataModel
{
    public class Device
    {
        #region Global Declaration
        DMSEntities entity = null;
        #endregion
        public void SaveDeviceIfNotRegister(Tbl_Device deviceObj)
        {
             entity = new DMSEntities();
            try
            {
                var v = entity.Tbl_Device.Where(p => p.DeviceId == deviceObj.DeviceId).ToList();
                if (v.Count() != 0)
                {
                    UpdateDevice(deviceObj);
                    return;
                }

                entity.Tbl_Device.Add(deviceObj);
                entity.SaveChanges();                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Tbl_Device GetDeviceDetails(string DeviceId)
        {
            entity = new DMSEntities();
            return entity.Tbl_Device.Where(p => p.DeviceId == DeviceId).FirstOrDefault();
        }

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="deviceObj"></param>
        public void UpdateDevice(Tbl_Device deviceObj)
        {
            entity = new DMSEntities();
            Tbl_Device DeviceObj = entity.Tbl_Device.Where(p => p.DeviceId == deviceObj.DeviceId).FirstOrDefault();
            DeviceObj.IsShutdownDevice = false;
            entity.SaveChanges();
        }
               
        public void SaveScreenshot(Tbl_ScreenshotDetails screenObj)
        {
             entity = new DMSEntities();
            try
            {
                entity.Tbl_ScreenshotDetails.Add(screenObj);
                entity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }       
    }
}
