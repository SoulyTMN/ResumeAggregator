using Newtonsoft.Json;
using ResumeAggregator.Models;
using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeAggregator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Агрегатор резюме";

            return View();
        }
        public string RefreshData(string jsonResponse)
        {
            try
            {
                E1CV cv = JsonConvert.DeserializeObject<E1CV>(jsonResponse);
                E1toInternalSaveHelper.ParseE1(cv);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "База успешно обновлена!";
        } 
    }
}
