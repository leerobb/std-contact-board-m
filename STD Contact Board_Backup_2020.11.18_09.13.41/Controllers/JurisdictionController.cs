using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.Ajax.Utilities;
using STD_Contact_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STD_Contact_Board.Controllers
{
    public class JurisdictionController : Controller
    {
        private readonly IJurisdictionService productService;

        public JurisdictionController()
        {
           productService = new JurisdictionService(ApplicationDbContext.Create());
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
        }

        // GET: Jurisdiction
        public ActionResult Jurisdiction()
        {
            PopulateViewData();

            if (!User.Identity.IsAuthenticated)
                return View("~/Views/Account/Login.cshtml");
            else
                return this.User.IsInRole("EditAllContacts") ? (ActionResult)this.View(nameof(Jurisdiction)) : (ActionResult)this.View("MyJurisdiction");
        }

        public ActionResult MyJurisdiction()
        {
            PopulateViewData();

            if (!User.Identity.IsAuthenticated)
                return View("~/Views/Account/Login.cshtml");
            else
                return this.User.IsInRole("EditAllContacts") ? (ActionResult)this.View(nameof(Jurisdiction)) : (ActionResult)this.View("MyJurisdiction");
        }

        public ActionResult EditingInline_Read([DataSourceRequest] DataSourceRequest request, string stateId)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        public ActionResult GetJurisdiction([DataSourceRequest] DataSourceRequest request, string jurisId)
        {
            return Json(productService.FilteredRead(jurisId).ToDataSourceResult(request));
        }

        public ActionResult EditingInline_Read2([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.FilteredRead().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, Jurisdiction product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Create(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, Jurisdiction product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Update(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, Jurisdiction product)
        {
            if (product != null)
            {
                productService.Destroy(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    }
}