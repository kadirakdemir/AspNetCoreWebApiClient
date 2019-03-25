using AspNetCoreWebApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ViewModels
{
    public class EditProductViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
    }
}
