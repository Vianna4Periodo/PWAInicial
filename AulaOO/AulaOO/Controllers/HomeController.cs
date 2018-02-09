using AulaOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulaOO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var conta = new Conta(0.0);
            var resposta = conta.Sacar(10);
            return View();
        }
    }
}