using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using AspNetCoreWebApi.Client.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.Components
{
    public class CategoryProducts : ViewComponent
    {
        private readonly IProductClientManager _productClientManager;
        public CategoryProducts(IProductClientManager productClientManager)
        {
            _productClientManager = productClientManager;
        }

        public IViewComponentResult Invoke(int id)
        {           
            var products = _productClientManager.GetAll().Where(x=>x.CategoryId==id);
            return View(products);
        }
    }
}
