using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using STD_Contact_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STD_Contact_Board.Controllers
{
    public class STD_RoleController : Controller
    {
        private STD_Contact_Board.Models.ISTD_RoleService productService;

        public STD_RoleController()
        {
            this.productService = (ISTD_RoleService)new STD_RoleService(ApplicationDbContext.Create());
        }

        public ActionResult STD_Role()
        {
            if (!User.Identity.IsAuthenticated)
                return View("~/Views/Account/Login.cshtml");
            else
                return this.User.IsInRole("EditAllContacts") ? (ActionResult)this.View(nameof(STD_Role)) : (ActionResult)this.View("~/Views/Contact/ReadContacts.cshtml");
         
        }

        public ActionResult Roles()
        {
            var dataContext = new ApplicationDbContext();
            var stdRoles = dataContext.STD_Roles
                        .Select(c => new STD_Role
                        {
                            Id = c.Id,
                            Name = c.Name
                        })
                        .OrderBy(e => e.Name);

            return Json(stdRoles, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return (ActionResult)this.Json((object)this.productService.Read().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, STD_Role product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Create(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, STD_Role product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Update(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, STD_Role product)
        {
            if (product != null)
            {
                productService.Destroy(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
    }
}