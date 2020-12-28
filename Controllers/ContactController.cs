using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using STD_Contact_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace STD_Contact_Board.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService productService;

        public ContactController()
        {
           productService = new ContactService(ApplicationDbContext.Create());
        }

        // GET: Contact
        public ActionResult Contact()
        {
            PopulateViewData();
            if (!User.Identity.IsAuthenticated)
                return View("~/Views/Account/Login.cshtml");
            else
                return (ActionResult)this.View("Contact");

          
        }

    
        public ActionResult ReadContacts()
        {
            return View();
        }

        private void PopulateViewData()
        {
            this.ViewData["jurisdictions"] = (object)new ApplicationDbContext().Jurisdictions.Select(product => new
            {
                Id = product.Id,
                JurisdictionName = product.JurisdictionName,
                AgencyName = product.AgencyName,
                MainAddress = product.MainAddress,
                Phone = product.Phone,
                Fax = product.Fax
            }).ToList().Select(x => new Jurisdiction()
        {
            Id = x.Id,
                JurisdictionName = x.JurisdictionName,
                AgencyName = x.AgencyName,
                MainAddress = x.MainAddress,
                Phone = x.Phone,
                Fax = x.Fax
            }).ToList<Jurisdiction>();

            this.ViewData["roles"] = (object)new ApplicationDbContext().STD_Roles.Select(product => new
            {
                Id = product.Id,
                Name = product.Name,

            }).ToList().Select(x => new STD_Role()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList<STD_Role>();

            //CREATE STATE IN TOP LEFT CORNER
            // Create manager
            var manager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(
                    new ApplicationDbContext()));

            // Find user
            var user = manager.FindById(User.Identity.GetUserId());

            if(!User.IsInRole("EditAllContacts"))
            {
                this.ViewData["currentJurisdiction"] = (object) new ApplicationDbContext().Jurisdictions.ToList()
                    .Find(x => x.Id == user.Jurisdiction).JurisdictionName;
            }
        }

        public ActionResult EditingInline_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        public ActionResult GetContact([DataSourceRequest] DataSourceRequest request, string jurisId, string roleId)
        {
            return Json(productService.FilteredRead(jurisId, roleId).ToDataSourceResult(request));
        }

        public ActionResult ReadAllContact([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.ReadAll().ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MyJuris_Create([DataSourceRequest] DataSourceRequest request, Contact product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.JurisCreate(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, Contact product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Create(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }



        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, Contact product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Update(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, Contact product)
        {
            if (product != null)
            {
                productService.Destroy(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
    }
}