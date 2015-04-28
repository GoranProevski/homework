using Register.BusinessLayer;
using Register.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bikes.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserDisplayCommand comm = new UserDisplayCommand();
            UserDisplayResult result = CommandInvoker.InvokeCommand<UserDisplayCommand, UserDisplayResult>(comm);
            return View(result.Users);
        }
    }
}