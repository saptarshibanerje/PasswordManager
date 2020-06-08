using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PasswordManager.Models;
using PasswordManager.Modules;

namespace PasswordManager.Controllers
{
    public class TrackController : Controller
    {
        // GET: Track
        public ActionResult Index()
        {
            ViewBag.Title = "Track Details";
            return View();
        }
        [HttpPost]
        public  ActionResult Index(Track objTrack)
        {
            if (ModelState.IsValid)
            {
                int resultid = new TrackModules().SaveTrackDetails(objTrack);
            }
            ViewBag.Title = "Track Details";
            return View();
        }
    }
}