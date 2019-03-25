using AspNetCoreWebApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ViewModels
{
    public class EditCategoryViewModel:BaseViewModel
    {
        public EditCategoryViewModel()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
