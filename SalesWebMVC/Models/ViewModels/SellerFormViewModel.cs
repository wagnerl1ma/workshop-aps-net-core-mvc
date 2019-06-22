using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
