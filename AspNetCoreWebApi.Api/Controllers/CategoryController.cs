using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApi.Api.Infrastructure.Interfaces;
using AspNetCoreWebApi.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult> GetCategory()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return Ok(categories);
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound("Kategori bulunamadı.");
            }
            return Ok(category);
        }

        // POST: api/Category
        [HttpPost]
        public async Task<ActionResult> PostCategory([FromBody] Category category)
        {
            try
            {
                if (category == null)
                {
                    return BadRequest("Geçersiz istek.");
                }

                _categoryRepository.Add(category);
                await _categoryRepository.SaveChangesAsync();
                return CreatedAtAction("GetCategory", new { id = category.Id }, category);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //PUT: api/Category/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCategory(int id, [FromBody] Category category)
        {
            try
            {
                if (category == null)
                {
                    return BadRequest("Geçersiz istek");
                }
               
                _categoryRepository.Update(category);
                await _categoryRepository.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await _categoryRepository.GetByIdAsync(id);
                if (category==null)
                {
                    return NotFound("Kategori bulunamadı.");
                }
                _categoryRepository.Delete(category);
                await _categoryRepository.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}