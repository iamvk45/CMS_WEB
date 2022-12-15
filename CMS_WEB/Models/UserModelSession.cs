using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_WEB.Models
{
    public class UserModelSession
    {
        public string PartyId { get; set; }
        public string Hirarchy { get; set; }
        public string Type { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string ServicesCollection { get; set; }
        public string IsActive { get; set; }
        public string PartialOrderID { get; set; }
        public string RegistrationNo { get; set; }
        public string profileImage { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CompanyType { get; set; }
    }


    public class UserPermissions
    {
        public int MappedSubmenuId { get; set; }
        public int MenuId { get; set; }
        public string Menu { get; set; }
        public int SubMenuId { get; set; }
        public string SubMenu { get; set; }
        public string Controller { get; set; }
        public string ActionMethod { get; set; }
        public string Allow_Insert { get; set; }
        public string Allow_Edit { get; set; }
        public string Allow_Delete { get; set; }
        public string Allow_View { get; set; }
    }
}