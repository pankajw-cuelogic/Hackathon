using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hackathon.DMS.DataLayer;
using Hackathon.DMS.Web.Models;
using Hackathon.DMS.Web.Blob;

namespace Hackathon.DMS.Web.Controllers
{
    public class DeviceController : Controller
    {
        
        #region Global diclaration
        DataLayer.DataModel.ScreenDetails deviceObj = new DataLayer.DataModel.ScreenDetails();
        #endregion
        //
        // GET: /Device/
        public ActionResult GetAllOnlineDevices()
        {
            return View();
        }
        /// <summary>
        /// Auther : Get latest screen shots
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetScreensByDeviceId(string deviceId)
        {
            try
            {              
                var screenObj = prepareViewModel(deviceObj.GetScreensByDeviceId(deviceId));
                return Json(new { Rresult = screenObj, Message = "Screen list" });
            }
            catch (Exception)
            {
                return Json(new { Message = "Getting error in Screen list" });
                throw;
            }
        }

        public ActionResult Index()
        {
            List<DataLayer.EntityModel.Tbl_Device> deviceList = new List<DataLayer.EntityModel.Tbl_Device>();
            DeviceViewModel deviceobj = new DeviceViewModel();
            try
            {
                deviceList = deviceObj.GetAllOnlineDevices();
                return View("Index", deviceList);
            }
            catch (Exception)
            {
                return Json(new { Message = "Error Occoured in getting device list" });
                throw;
            }
        }

        public List<DeviceViewModel> prepareViewModel(List<DataLayer.EntityModel.Tbl_ScreenshotDetails> listObj)
        {
            List<DeviceViewModel> devList = new List<DeviceViewModel>();
            foreach (var x in listObj)
            {
                DeviceViewModel devObj = new DeviceViewModel();
                devObj.Id = x.Id;
                devObj.Fk_DeviceId = x.Fk_DeviceId;
                devObj.CreatedDate = x.CreatedDatetime;
                devObj.Screenshot = string.Format("data:image/gif;base64,{0}",  System.Convert.ToBase64String( new Download().DownloadFileFromBlob(x.ScreenshotPath)));
                devList.Add(devObj);
            }
            return devList;
        }

        public ActionResult DeviceEdit()
        {
            List<DataLayer.EntityModel.Tbl_Device> deviceList = new List<DataLayer.EntityModel.Tbl_Device>();
            DeviceViewModel deviceobj = new DeviceViewModel();
            try
            {

                deviceList = deviceObj.GetAllDevices();
                return View("DeviceEdit", deviceList);
            }
            catch (Exception)
            {
                return Json(new { Message = "Error Occoured in getting device list" });
                throw;
            }
        }

        /// <summary>
        /// Shutdown device by id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ShutdownByDeviceId(string deviceId)
        {
            try
            {
                var screenObj = deviceObj.UpdateDeviceById(deviceId, true);
                return Json(new { Rresult = screenObj, Message = "Device Shutdown" });
            }
            catch (Exception)
            {
                return Json(new { Message = "Getting error in shutdown update" });
                throw;
            }
        }
    }
}