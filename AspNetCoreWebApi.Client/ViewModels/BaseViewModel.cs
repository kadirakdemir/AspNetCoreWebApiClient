using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
