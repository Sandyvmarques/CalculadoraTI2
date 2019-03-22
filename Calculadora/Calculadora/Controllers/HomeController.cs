using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }




		// POST: Home
		//anotacoes sao escritas em []
		[HttpPost]
		//este visor traz o nr antigo 
		//le da view o valor q esta na view, para aora seremos capazes de processar os dados 
		public ActionResult Index(string visor , string btn)
		{
			switch (btn) {
				case "0":
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
					if (visor == "0")
					{
						visor = btn;
					}
					else {
						visor += btn;
					}
					break;

			}
			ViewBag.Resposta = visor;
			return View();
		}
	}
}