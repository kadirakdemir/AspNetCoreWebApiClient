using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using AspNetCoreWebApi.Client.Models;
using AspNetCoreWebApi.Client.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryClientManager _categoryClientManager;

        public CategoryController(ICategoryClientManager categoryClientManager)
        {
            _categoryClientManager = categoryClientManager;
            _categoryClientManager.Url("https://localhost:44386/api/", "Category");
        }

        // GET: Category
        public IActionResult Index()
        {
            ICollection<Category> category = _categoryClientManager.GetAll();
            return View(category);
        }

        // GET: Category/Details/5
        public IActionResult Details(int id)
        {
            var category = _categoryClientManager.GetById(id);
            return View(category);
        }
        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public IActionResult Create(EditCategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category dbcategory = new Category()
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    IsActive = category.IsActive
                };

                _categoryClientManager.Add(dbcategory);
                RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var category = await _categoryClientManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound("Kategori bulunamadı.");
            }

            EditCategoryViewModel categoryvm = new EditCategoryViewModel()
            {
                Id = id,
                IsActive = category.IsActive,
                CategoryName = category.CategoryName,
                Products = category.Products
            };

            return View(categoryvm);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, EditCategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category dbcategory = new Category()
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    IsActive = category.IsActive
                };
                _categoryClientManager.Update(id, dbcategory);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public IActionResult Delete(int id)
        {
            var category = _categoryClientManager.GetById(id);
            if (category == null)
            {
                return NotFound("Ürün bulunamadı.");
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _categoryClientManager.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}