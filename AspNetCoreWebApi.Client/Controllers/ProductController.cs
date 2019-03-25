using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using AspNetCoreWebApi.Client.Models;
using AspNetCoreWebApi.Client.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductClientManager _productClientManager;
        private readonly ICategoryClientManager _categoryClientManager;

        public ProductController(IProductClientManager productClientManager,ICategoryClientManager categoryClientManager)
        {
            _productClientManager = productClientManager;
            _categoryClientManager = categoryClientManager;
            _productClientManager.Url("https://localhost:44386/api/", "Product");
            _categoryClientManager.Url("https://localhost:44386/api/", "Category");
        }

        // GET: Product
        public IActionResult Index()
        {
            ICollection<Product> products = _productClientManager.GetAll(); 
            return View(products);
        }

        // GET: Product/Create
        public IActionResult Create()
        {           
            EditProductViewModel productvm = new EditProductViewModel();
            productvm.Categories= _categoryClientManager.GetAll();
            return View(productvm);
        }

        // POST: Product/Create
        [HttpPost]
        public IActionResult Create(EditProductViewModel productvm)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Name=productvm.Name,
                    IsActive=productvm.IsActive,
                    Price=productvm.Price,
                    Stock=productvm.Stock,
                    CategoryId=productvm.CategoryId
                };
                
                _productClientManager.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(productvm);
        }

        // GET: Product/Edit/5        
        public async Task<ActionResult> Edit(int id)
        {
            var product = await _productClientManager.GetByIdAsync(id);
            if (product==null)
            {
                return NotFound("Ürün bulunamadı.");
            }

            EditProductViewModel productvm = new EditProductViewModel()
            {
                Id=id,
                Name=product.Name,
                IsActive=product.IsActive,
                Price=product.Price,
                CategoryId=product.CategoryId,
                Stock=product.Stock
            };
            productvm.Categories = await _categoryClientManager.GetAllAsync();
            return View(productvm);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, EditProductViewModel productvm)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Id=id,
                    Name = productvm.Name,
                    IsActive = productvm.IsActive,
                    Price = productvm.Price,
                    Stock = productvm.Stock,
                    CategoryId = productvm.CategoryId
                };
                _productClientManager.Update(id,product);
                return RedirectToAction(nameof(Index));
            }
            return View(productvm);
        }

        // GET: Product/Delete/5
        public IActionResult Delete(int id)
        {
            var product = _productClientManager.GetById(id);
            if (product==null)
            {
               return NotFound("Ürün bulunamadı.");
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _productClientManager.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}