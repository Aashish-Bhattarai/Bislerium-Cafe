using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_MilanJoshi.Models
{
    public class OrderModel
    {
        public string SelectedCoffee { get; set; }
        public string SelectedAddIn { get; set; }
        public decimal AddInPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
