﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.MVC.Models;
using Store.BLL.Services;
using Store.BLL.DTO;
using Store.BLL.Interfaces;
using Store.BLL.BusinesModels;
using AutoMapper;

namespace Store.MVC.Controllers
{
    public class HomeController : Controller
    {

        //ProductService db = new ProductService();
        //IProductService db;
        public HomeController(IProductService serv)
        {
            this.db = serv;
        }
        public ActionResult Index()
        {
            IEnumerable<ProductDTO> productDTO = db.GetAll();
            Mapper.Initialize(n => n.CreateMap<ProductDTO, ProductViewModel>());
            var products = Mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDTO);
            return View(products);            
        }
        private readonly IProductService db;
    }
}