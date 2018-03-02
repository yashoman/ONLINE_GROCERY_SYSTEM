using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OGS_Library;
using OGS_Library.IRepository;
using OGS_Library.Repository;


namespace OGS_MVC.Models.BusinessLogic
{
    public class OrderBusinessLogic
    {
        private OGSEntities context;
        public IOrder_Repository iOrderepository;
        public IOrder_Detail_Repository iOrderDetailRepository;


        public OrderBusinessLogic()
        {
            context = new OGSEntities();
            iOrderepository = new Order_Repository(context);
            iOrderDetailRepository = new Order_Detail_Repository(context);

        }


        //----------start-save Porder-----------------------------
        public Order_ViewModel SubmitPurchaceOrder(Order_ViewModel usrQty)
        {
            try
            {
                ORDER _purOdr = new ORDER();
                _purOdr.ORDER_ID = usrQty.OrderId;
                _purOdr.SUPER_MARKET_ID = usrQty.SuperMarketId;
                _purOdr.CUSTOMER_ID = usrQty.CustomerId;
                _purOdr.STATUS = usrQty.Status;
                _purOdr.CREATED_DATE = usrQty.CreatedDate;
                _purOdr.CREATED_USER = usrQty.CreatedUser;
                _purOdr.MODIFIED_DATE = usrQty.ModifieDate;
                _purOdr.MODIFIED_USER = usrQty.ModifiedUser;
                
                var res = iOrderepository.Insert(_purOdr);
                if (res != null)
                {
                    usrQty.OrderId = res.ORDER_ID;
                }
                SubmitPurchaceOrderDtl(usrQty);
            }
            catch (Exception ex)
            { }
            return usrQty;
        }
        // Save purchase order hd
        public Order_ViewModel SubmitPurchaceOrderDtl(Order_ViewModel usrQty)
        {
            try
            {
                for (int i = 0; i < usrQty.OrderDetails.Count; i++)
                {
                    ORDER_LINE_ITEMS _purOdr = new ORDER_LINE_ITEMS();
                    _purOdr.ORDER_ID = usrQty.OrderId;
                    _purOdr.OFFERS_ID = usrQty.OrderDetails[i].OffersId;
                    _purOdr.PRODUCT_ID = usrQty.OrderDetails[i].ProductId;
                    _purOdr.PRICE = usrQty.OrderDetails[i].Price;
                    _purOdr.QUANTITY = usrQty.OrderDetails[i].Qty;
                    _purOdr.TOTAL_AMOUNT = usrQty.OrderDetails[i].TotalAmount;
                   
                    var res = iOrderDetailRepository.Insert(_purOdr);
                    if (res != null)
                    {
                        usrQty.OrderId = res.ORDER_ID;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return usrQty;
        }
        //----------end-save Porder-------------------------------

    }
}