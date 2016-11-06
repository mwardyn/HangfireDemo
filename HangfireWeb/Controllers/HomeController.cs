using System;
using System.Web.Mvc;
using Hangfire;
using HangfireJobs;

namespace HangfireWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Add()
        {
            RecurringJob.AddOrUpdate<FailingJob>(x=>x.RunJob(), Cron.Daily(5));
            return this.Redirect("\\hangfire");
        }
    }
}