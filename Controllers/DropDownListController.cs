using Microsoft.AspNet.Identity;
using STD_Contact_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STD_Contact_Board.Controllers
{
    public class DropDownListController : Controller
    {
        // GET: DropDownList
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStates()
        {
            //this.User.Identity.GetUserId();

            var stateList = new ApplicationDbContext().Jurisdictions.Select(entry => new
            {
                entry.Id,
                entry.JurisdictionName,
                entry.AgencyName,
                entry.MainAddress,
                entry.Phone,
                entry.Fax
            }).ToList().Select(x => new STD_Contact_Board.Models.Jurisdiction()
            {
                Id = x.Id,
                JurisdictionName = x.JurisdictionName,
                AgencyName = x.AgencyName,
                MainAddress = x.MainAddress,
                Phone = x.Phone,
                Fax = x.Fax
            }).ToList<STD_Contact_Board.Models.Jurisdiction>().ToList<STD_Contact_Board.Models.Jurisdiction>();

            return Json(stateList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRoles()
        {
            //this.User.Identity.GetUserId();

            var roleList = new ApplicationDbContext().STD_Roles.Select(entry => new
            {
                entry.Id,
                entry.Name    
            }).ToList().Select(x => new STD_Contact_Board.Models.STD_Role()
            {
                Id = x.Id,
                Name = x.Name,
               
            }).ToList<STD_Contact_Board.Models.STD_Role>().ToList<STD_Contact_Board.Models.STD_Role>();

            var allRoles = new STD_Role
            {
                Id = 100,
                Name = "ALL"
            };

            roleList.Insert(0,allRoles);

            return Json(roleList, JsonRequestBehavior.AllowGet);
        }
    }
}