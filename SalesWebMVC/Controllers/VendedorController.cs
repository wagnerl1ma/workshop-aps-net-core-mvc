﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class VendedorController : Controller
    {
        private readonly SellerService _sellerService;

        public VendedorController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  //anotação
        [ValidateAntiForgeryToken]  //anotação
        public IActionResult Create(Vendedor vendedor)
        {
            _sellerService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}