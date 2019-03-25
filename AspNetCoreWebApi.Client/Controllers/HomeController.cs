using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using AspNetCoreWebApi.Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreWebApi.Client.Controllers
{
    public class HomeController : Controller
    {
        #region Dependency Injection

        private readonly IProductClientManager _productClientManager;
        private readonly ICategoryClientManager _categoryClientManager;

        public HomeController(IProductClientManager productClientManager, ICategoryClientManager categoryClientManager)
        {
            _productClientManager = productClientManager;
            _categoryClientManager = categoryClientManager;
            _productClientManager.Url("https://localhost:44386/api/", "Product");
            _categoryClientManager.Url("https://localhost:44386/api/", "Category");
        }

        #endregion
        public IActionResult Index()
        {
            ICollection<Category> category = _categoryClientManager.GetAll();
            return View(category);
        }
    }
}