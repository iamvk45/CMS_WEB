using CMS_WEB.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace CMS_WEB.Controllers
{
    public class AuthenticationController : Controller
    {
        API_Common_Res _Common_Res = new API_Common_Res();

        [ActionName("login-alt")]
        public ActionResult loginAlt() => View();
        
        [ActionName("recover-pw")]
        public ActionResult recoverPw() => View();

        [HttpPost]
        public ActionResult Login(Login login)
        {
            try
            {
                var json = JsonConvert.SerializeObject(login);
                var client = new RestClient(ConfigurationManager.AppSettings["BASEURL"] + "Auth/Login");
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("authorization", "bearer " + CurrentSessions.Token + "");
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                IRestResponse response = client.Execute(request);

                if (response.StatusCode.ToString() == "OK")
                {
                    _Common_Res = JsonConvert.DeserializeObject<API_Common_Res>(response.Content);
                    if (_Common_Res.Data != null)
                    {
                        var userModel = JsonConvert.DeserializeObject<UserModelSession>(_Common_Res.Data.ToString());
                        //List<UserPermissions> permissions = AdminAjaxRequestPageController.GetPermissionDetails(userModel.RoleId, userModel.DepartmentId);
                        //List<NotificationMaster> notificationsData = ZapurseCommonlist.GetNotificationMaster();

                        if (userModel.PartyId == "A000001")
                        {
                            //if (permissions != null)
                            //{
                            Session["Token"] = _Common_Res.JWT;
                            Session["UserDetails"] = userModel;
                            //Session["UserPermissions"] = permissions;
                            //Session["notificationList"] = notificationsData;

                            //}
                            //return RedirectToAction("Index", "Dashboard");
                            //return RedirectToAction("Dashboard", "DashboardReport");
                            return RedirectToAction("Index", "Dashboard");

                        }
                        else if (userModel.IsActive == "0")
                        {
                            TempData["IsUserDetailsExists"] = 1;
                            TempData["msg"] = "Your Account is blocked Please Contact to admin...";
                            return RedirectToAction("login-alt", "authentication");
                        }
                        else if (userModel.Type == "6")
                        {
                            //if (permissions != null)
                            //{
                            Session["Token"] = _Common_Res.JWT;
                            Session["UserDetails"] = userModel;
                            //Session["UserPermissions"] = permissions;
                            //Session["notificationList"] = notificationsData;

                            //}
                            //return RedirectToAction("Index", "Welcome");
                            //return RedirectToAction("Dashboard", "DashboardReport");
                            return RedirectToAction("Index", "Dashboard");
                        }
                        else
                        {
                            //if (permissions != null)
                            //{
                            //    Session["Token"] = _Common_Res.JWT;
                            //    Session["UserDetails"] = userModel;
                            //    Session["UserPermissions"] = permissions;
                            //    Session["notificationList"] = notificationsData;

                            //    return RedirectToAction("Index", "Welcome");
                            //}
                            return RedirectToAction("Index", "Dashboard");
                        }
                    }

                    if (_Common_Res.Message.Contains("User Details Not Found..."))
                    {
                        TempData["IsUserDetailsExists"] = 1;
                        TempData["msg"] = "Invalid Credentials Please Try Again...";
                        return RedirectToAction("login-alt", "authentication");

                    }
                    else
                    {
                        TempData["IsUserDetailsExists"] = 0;
                        //return RedirectToAction("Index", "Welcome");
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                else
                {
                    TempData["IsUserDetailsExists"] = 1;
                    return RedirectToAction("login-alt", "authentication");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult SignOut1()
        {
            Session["UserDetails"] = null;
            Session["Token"] = null;
            //Session["UserAllDetails"] = null;

            return new JsonResult
            {
                Data = new { StatusCode = 1, Data = "Logged out successfully", failure = false, msg = "Success" },
                ContentEncoding = System.Text.Encoding.UTF8,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}