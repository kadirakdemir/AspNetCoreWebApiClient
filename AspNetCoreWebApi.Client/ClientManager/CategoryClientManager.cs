using AspNetCoreWebApi.Client.ClientManager.Interfaces;
using AspNetCoreWebApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ClientManager
{
    public class CategoryClientManager:BaseClientManager<Category>,ICategoryClientManager
    {
    }
}
