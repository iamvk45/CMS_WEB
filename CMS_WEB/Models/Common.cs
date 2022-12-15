using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CMS_WEB.Models
{
    public class Common
    {
        public enum ModalSize
        {
            Small,
            Medium,
            Large
        }
        public static List<NotificationOperationData> NotificationOperation(NotificationOperationRequest notificationOperation)
        {
            List<NotificationOperationData> notificationData = new List<NotificationOperationData>();

            //var json = JsonConvert.SerializeObject(notificationOperation);
            //var client = new RestClient(ConfigurationManager.AppSettings["BaseUrl"] + "RoleMaster/NotificationOperation");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("authorization", "bearer " + CurrentSessions.Token + "");
            //request.AddParameter("application/json", json, ParameterType.RequestBody);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Accept", "application/json");
            //IRestResponse response = client.Execute(request);

            //ResponseData requestResponse = new ResponseData();
            //if (response.StatusCode.ToString() == "OK")
            //{
            //    requestResponse = JsonConvert.DeserializeObject<ResponseData>(response.Content);
            //}

            //if (notificationOperation.Type == "MarkasRead" || notificationOperation.Type == "Delete")
            //{
            //    requestResponse.Data = null;
            //    notificationData = new List<NotificationOperationData>();
            //}
            //else
            //{
            //    if (requestResponse.Data != null)
            //    {
            //        notificationData = JsonConvert.DeserializeObject<List<NotificationOperationData>>(requestResponse.Data.ToString());
            //    }
            //    else
            //    {
            //        notificationData = new List<NotificationOperationData>();
            //    }
            //}
            return notificationData;
        }

    }
    public class Dropdown
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string ID1 { get; set; }
        public string PartyId { get; set; }
    }
}