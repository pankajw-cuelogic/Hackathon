using Hackathon.DMS.DataLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.DMS.DataLayer.DataModel
{
  public class ScreenDetails
    {
        /// <summary>
        /// Get screen shot by device Id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public List<Tbl_ScreenshotDetails> GetScreensByDeviceId(string deviceId)
        {
            DMSEntities ent = new DMSEntities();
            List<Tbl_ScreenshotDetails> screenList = new List<Tbl_ScreenshotDetails>();
            DateTime dt = (System.DateTime.Now).AddMinutes(-10);
            screenList = (from t in ent.Tbl_ScreenshotDetails
                     where t.Fk_DeviceId == deviceId
                     && t.CreatedDatetime >= dt select t).ToList();
            return screenList;
        }

        /// <summary>
        /// Get all online devices
        /// </summary>
        /// <returns></returns>
        public List<Tbl_Device> GetAllOnlineDevices()
        {
            DateTime dt = (System.DateTime.Now).AddMinutes(-10);
            DMSEntities ent = new DMSEntities();
            var v = (from t in ent.Tbl_Device
                     join t1 in ent.Tbl_ScreenshotDetails on t.DeviceId equals t1.Fk_DeviceId
                     where t1.CreatedDatetime >= dt
                     select t).Distinct().ToList();
            return v;
        }
         
        /// <summary>
        /// Get all register devices
        /// </summary>
        /// <returns></returns>
        public List<Tbl_Device> GetAllDevices()
        {
            DMSEntities ent = new DMSEntities();
            return ent.Tbl_Device.ToList();
        }

        /// <summary>
        /// Update Device table to shutdown
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="IsShutdown"></param>
        public Boolean UpdateDeviceById(string deviceId, Boolean IsShutdown)
        {
            DMSEntities entity = new DMSEntities();
            Tbl_Device DeviceObj = entity.Tbl_Device.Where(p => p.DeviceId == deviceId).FirstOrDefault();
            DeviceObj.IsShutdownDevice = IsShutdown;
            entity.SaveChanges();
            return true;
        }
    }
}
