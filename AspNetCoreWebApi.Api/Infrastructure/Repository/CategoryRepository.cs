using AspNetCoreWebApi.Api.Infrastructure.Context;
using AspNetCoreWebApi.Api.Infrastructure.Interfaces;
using AspNetCoreWebApi.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Api.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
