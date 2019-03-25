using AspNetCoreWebApi.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Api.Infrastructure.Interfaces
{
    public interface IProductRepository:IRepository<Product>
    {
    }
}
