using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OGS_MVC.Models
{
    public class SalesModel
    {
    }

    public partial class Order_ViewModel
    {
        public Order_ViewModel()
        {
            this.OrderDetails = new List<Order_Detail_ViewModel>();
        }

        public List<Order_Detail_ViewModel> OrderDetails { get; set; }
        public decimal OrderId { get; set; }
        public string SuperMarketId { get; set; }
        public string CustomerId { get; set; }
        public Nullable<decimal> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> ModifieDate { get; set; }
        public string ModifiedUser { get; set; }
    }

    public partial class Order_Detail_ViewModel
    {
        public decimal OrderId { get; set; }
        public decimal ProductId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> Status { get; set; }
        public string OffersId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> ModifieDate { get; set; }
        public string ModifiedUser { get; set; }
    }

}