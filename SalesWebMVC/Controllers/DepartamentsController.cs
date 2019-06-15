using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            //enviando dados do controller para a View
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            lista.Add(new Departamento { Id = 2, Nome = "Fashion" });

            return View(lista);
        }
    }
}